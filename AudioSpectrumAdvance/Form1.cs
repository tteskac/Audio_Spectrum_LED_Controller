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

namespace AudioSpectrumAdvance
{
    public partial class Form1 : Form
    {

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

            analyzer = new Analyzer(spectrum1, comboBox1, trackBar1, trackBar2);
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _led_value = getAverage(analyzer.getAverageValue());
                panel1.Width = _led_value;
            
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                connect();
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                _cmd = ":C= 255;";
                byte[] send_buffer = Encoding.ASCII.GetBytes(_cmd);
                sending_socket.SendTo(send_buffer, sending_end_point);
            }
        }

        private void connect()
        {
            sending_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            send_to_address = IPAddress.Parse(textBox1.Text);
            sending_end_point = new IPEndPoint(send_to_address, int.Parse(textBox2.Text));
        }


        private void getSettings()
        {
            timer1.Interval = Properties.Settings.Default.timer_interval;

            trackBar1.Value = Properties.Settings.Default.ch_from;
            trackBar2.Value = Properties.Settings.Default.ch_to;
            textBox1.Text = Properties.Settings.Default.ip_address;
            textBox2.Text = Properties.Settings.Default.ip_port;

            trackBar4.Value = Properties.Settings.Default.average_count;
            label4.Text = trackBar4.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ch_from = trackBar1.Value;
            Properties.Settings.Default.ch_to = trackBar2.Value;
            Properties.Settings.Default.ip_address = textBox1.Text;
            Properties.Settings.Default.ip_port = textBox2.Text;
            Properties.Settings.Default.average_count = trackBar4.Value;

            Properties.Settings.Default.Save();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar1.Value > trackBar2.Value)
            {
                trackBar2.Value = trackBar1.Value;
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar2.Value < trackBar1.Value)
            {
                trackBar1.Value = trackBar2.Value;
            }
        }

        private int getAverage(int value)
        {
            _average.Add(value);

            while (_average.Count > trackBar4.Value)
            {
                _average.RemoveAt(0);
            }

            return (int) (_average.Sum() / _average.Count());
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = trackBar4.Value.ToString();
        }
    }
}
