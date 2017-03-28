using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Net.Sockets;
using System.Resources;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace AudioSpectrumAdvance
{
    public partial class Form1 : Form
    {
        const string APP_VERSION = "0.2";

        #region TrayBaloon
        NotifyIcon notifyIcon;
        const string TRAY_TITLE = "LED Ambient light controller";
        const int TRAY_BALOON_DURATION = 1000;
        #endregion

        Analyzer analyzer;
        private int _led_value = 255;
        private string _cmd = "";
        private string _last_cmd = "";
        Socket sending_socket;
        IPAddress send_to_address;
        IPEndPoint sending_end_point;
        List<int> _average = new List<int>();
        

        public Form1()
        {
            InitializeComponent();

            getSettings();

            analyzer = new Analyzer(spectrum1, comboBox_soundcard_list, trackBar_low_ch, trackBar_high_ch);
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowBalloonTip();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _led_value = (int) map(
                    getAverage(analyzer.getAverageValue()), 
                    0, 
                    255,
                    trackBar_minVal.Value,
                    trackBar_maxVal.Value);

                panel_led_brightness.Width = (int) map(_led_value, 0, 255, 0, groupBox_led_brightness.Width - 20);
            
                _cmd = ":C= " + _led_value + ";";       //This is the command that is sent over network 
                                                        // to Arduino that reads command in this form ":C= 255;"
                if (_cmd != _last_cmd)
                {
                    _last_cmd = _cmd;
                    byte[] send_buffer = Encoding.ASCII.GetBytes(_cmd);
                    sending_socket.SendTo(send_buffer, sending_end_point);
                }
            }
            catch (Exception) { }
        }

        private void checkBox_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_enabled.Checked)
            {
                connect();
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                _cmd = ":C= " + trackBar_minVal.Value + ";";
                byte[] send_buffer = Encoding.ASCII.GetBytes(_cmd);
                sending_socket.SendTo(send_buffer, sending_end_point);
            }
        }

        private void connect()
        {
            sending_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            send_to_address = IPAddress.Parse(textBox_ip.Text);
            sending_end_point = new IPEndPoint(send_to_address, int.Parse(textBox_port.Text));
        }


        private void getSettings()
        {
            timer1.Interval = Properties.Settings.Default.timer_interval;

            checkBox_start_with_windows.Checked = Properties.Settings.Default.start_with_windows;

            trackBar_low_ch.Value = Properties.Settings.Default.ch_from;
            trackBar_high_ch.Value = Properties.Settings.Default.ch_to;
            textBox_ip.Text = Properties.Settings.Default.ip_address;
            textBox_port.Text = Properties.Settings.Default.ip_port;

            trackBar_aggression.Value = Properties.Settings.Default.average_count;
            label_agression.Text = trackBar_aggression.Value.ToString();

            trackBar_minVal.Value = Properties.Settings.Default.min_value;
            label_minVal.Text = trackBar_minVal.Value.ToString();
            trackBar_maxVal.Value = Properties.Settings.Default.max_value;
            label_maxVal.Text = trackBar_maxVal.Value.ToString();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            RegisterInStartup(checkBox_start_with_windows.Checked);

            Properties.Settings.Default.ch_from = trackBar_low_ch.Value;
            Properties.Settings.Default.ch_to = trackBar_high_ch.Value;
            Properties.Settings.Default.ip_address = textBox_ip.Text;
            Properties.Settings.Default.ip_port = textBox_port.Text;
            Properties.Settings.Default.average_count = trackBar_aggression.Value;
            Properties.Settings.Default.min_value = trackBar_minVal.Value;
            Properties.Settings.Default.max_value = trackBar_maxVal.Value;
            
            Properties.Settings.Default.Save();
        }

        private void trackBar_low_ch_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar_low_ch.Value > trackBar_high_ch.Value)
            {
                trackBar_high_ch.Value = trackBar_low_ch.Value;
            }
        }

        private void trackBar_high_ch_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar_high_ch.Value < trackBar_low_ch.Value)
            {
                trackBar_low_ch.Value = trackBar_high_ch.Value;
            }
        }

        private int getAverage(int value)
        {
            _average.Add(value);

            while (_average.Count > trackBar_aggression.Value)
            {
                _average.RemoveAt(0);
            }

            return (int) (_average.Sum() / _average.Count());
        }

        private void trackBar_agression_ValueChanged(object sender, EventArgs e)
        {
            label_agression.Text = trackBar_aggression.Value.ToString();
        }


        private void track_minVal_ValueChanged(object sender, EventArgs e)
        {
            label_minVal.Text = trackBar_minVal.Value.ToString();
            //if (trackBar_minVal.Value > trackBar_maxVal.Value)
            //{
            //    trackBar_maxVal.Value = trackBar_minVal.Value;
            //}
        }

        private void track_maxVal_ValueChanged(object sender, EventArgs e)
        {
            label_maxVal.Text = trackBar_maxVal.Value.ToString();
            //if (trackBar_maxVal.Value < trackBar_minVal.Value)
            //{
            //    trackBar_minVal.Value = trackBar_maxVal.Value;
            //}
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                showBaloon("I'm now in the system tray");
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
        }


        //HELPERS
        float map(int x, int in_min, int in_max, int out_min, int out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }

        private void showWindow()
        {
            this.Show();
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        #region ICON TRAY
        private void ShowBalloonTip()
        {
            Container bpcomponents = new Container();
            ContextMenu contextMenu1 = new ContextMenu();
            MenuItem[] menuItems = new MenuItem[6];

            /*
                LED Ambient light controller
                Version: 0.2
                tteskac - 2017
                ----------------------------
                Settings
                Exit program
            */

            MenuItem menuItem = new MenuItem();
            menuItem.Index = 1;
            menuItem.Text = "LED Ambient light controller";
            menuItems[0] = menuItem;

            menuItem = new MenuItem();
            menuItem.Index = 2;
            menuItem.Text = "Version: " + APP_VERSION;
            menuItems[1] = menuItem;

            menuItem = new MenuItem();
            menuItem.Index = 3;
            menuItem.Text = "tteskac - 2017";
            menuItems[2] = menuItem;

            menuItem = new MenuItem();
            menuItem.Index = 4;
            menuItem.Text = "-------------------------";
            menuItems[3] = menuItem;

            menuItem = new MenuItem();
            menuItem.Index = 5;
            menuItem.Text = "Settings";
            menuItem.Click += new EventHandler(showSettings_Click);
            menuItems[4] = menuItem;

            menuItem = new MenuItem();
            menuItem.Index = 6;
            menuItem.Text = "Exit program";
            menuItem.Click += new EventHandler(exitMenu_Click);
            menuItems[5] = menuItem;

            // Initialize contextMenu1
            contextMenu1.MenuItems.AddRange(menuItems);

            // Create the NotifyIcon.
            notifyIcon = new NotifyIcon(bpcomponents);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            string iconPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Led.ico";
            notifyIcon.Icon = new Icon(iconPath);

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon.ContextMenu = contextMenu1;

            notifyIcon.Visible = true;

            notifyIcon.DoubleClick += new System.EventHandler(NotifyIcon1_DoubleClick);

        }

        private void NotifyIcon1_DoubleClick(object sender, System.EventArgs e)
        {
            showWindow();
        }

        void showBaloon(string text)
        {
            notifyIcon.BalloonTipTitle = TRAY_TITLE;
            notifyIcon.BalloonTipText = text.Length > 63 ? text.Substring(0, 63) : text;
            notifyIcon.Text = TRAY_TITLE;
            notifyIcon.ShowBalloonTip(TRAY_BALOON_DURATION);
        }

        void exitMenu_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            this.Close();
        }
        
        void showSettings_Click(object sender, EventArgs e)
        {
            showWindow();
        }

        #endregion ICON TRAY


        private void RegisterInStartup(bool isChecked)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                        ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (isChecked)
                {
                    registryKey.SetValue("LedAmbientLight", Application.ExecutablePath);
                }
                else
                {
                    try { registryKey.DeleteValue("LedAmbientLight"); } catch (Exception) { }
                }

                Properties.Settings.Default.start_with_windows = checkBox_start_with_windows.Checked;
                Properties.Settings.Default.Save();
            }
            catch (Exception e)
            {
                // an error! 
                MessageBox.Show(e.Message, "Start with Windows Error!");
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (checkBox_start_with_windows.Checked)
            {
                checkBox_enabled.Checked = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
