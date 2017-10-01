namespace AudioSpectrumAdvance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_soundcard_list = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar_low_ch = new System.Windows.Forms.TrackBar();
            this.trackBar_high_ch = new System.Windows.Forms.TrackBar();
            this.panel_led_brightness = new System.Windows.Forms.Panel();
            this.checkBox_enabled = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.trackBar_aggression = new System.Windows.Forms.TrackBar();
            this.label_agression = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_maxVal = new System.Windows.Forms.Label();
            this.trackBar_maxVal = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label_minVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar_minVal = new System.Windows.Forms.TrackBar();
            this.groupBox_led_brightness = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_start_with_windows = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.spectrum1 = new AudioSpectrumAdvance.Spectrum();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_low_ch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_high_ch)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_aggression)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_maxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_minVal)).BeginInit();
            this.groupBox_led_brightness.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_soundcard_list
            // 
            this.comboBox_soundcard_list.FormattingEnabled = true;
            this.comboBox_soundcard_list.Location = new System.Drawing.Point(459, 263);
            this.comboBox_soundcard_list.Name = "comboBox_soundcard_list";
            this.comboBox_soundcard_list.Size = new System.Drawing.Size(262, 21);
            this.comboBox_soundcard_list.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar_low_ch
            // 
            this.trackBar_low_ch.LargeChange = 1;
            this.trackBar_low_ch.Location = new System.Drawing.Point(12, 12);
            this.trackBar_low_ch.Maximum = 63;
            this.trackBar_low_ch.Name = "trackBar_low_ch";
            this.trackBar_low_ch.Size = new System.Drawing.Size(1288, 45);
            this.trackBar_low_ch.TabIndex = 7;
            this.trackBar_low_ch.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_low_ch.ValueChanged += new System.EventHandler(this.trackBar_low_ch_ValueChanged);
            // 
            // trackBar_high_ch
            // 
            this.trackBar_high_ch.LargeChange = 1;
            this.trackBar_high_ch.Location = new System.Drawing.Point(12, 38);
            this.trackBar_high_ch.Maximum = 63;
            this.trackBar_high_ch.Name = "trackBar_high_ch";
            this.trackBar_high_ch.Size = new System.Drawing.Size(1288, 45);
            this.trackBar_high_ch.TabIndex = 8;
            this.trackBar_high_ch.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_high_ch.Value = 63;
            this.trackBar_high_ch.ValueChanged += new System.EventHandler(this.trackBar_high_ch_ValueChanged);
            // 
            // panel_led_brightness
            // 
            this.panel_led_brightness.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_led_brightness.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_led_brightness.Location = new System.Drawing.Point(10, 16);
            this.panel_led_brightness.Name = "panel_led_brightness";
            this.panel_led_brightness.Size = new System.Drawing.Size(10, 18);
            this.panel_led_brightness.TabIndex = 9;
            // 
            // checkBox_enabled
            // 
            this.checkBox_enabled.AutoSize = true;
            this.checkBox_enabled.Location = new System.Drawing.Point(319, 25);
            this.checkBox_enabled.Name = "checkBox_enabled";
            this.checkBox_enabled.Size = new System.Drawing.Size(139, 17);
            this.checkBox_enabled.TabIndex = 14;
            this.checkBox_enabled.Text = "Communication enabled";
            this.checkBox_enabled.UseVisualStyleBackColor = true;
            this.checkBox_enabled.CheckedChanged += new System.EventHandler(this.checkBox_enabled_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.checkBox_enabled);
            this.groupBox1.Controls.Add(this.textBox_ip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(459, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 63);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Device";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(236, 23);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(70, 20);
            this.textBox_port.TabIndex = 3;
            this.textBox_port.Text = "8888";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(75, 23);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(120, 20);
            this.textBox_ip.TabIndex = 2;
            this.textBox_ip.Text = "192.168.137.165";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP address:";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(727, 263);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(195, 46);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "Save settings";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // trackBar_aggression
            // 
            this.trackBar_aggression.Location = new System.Drawing.Point(7, 43);
            this.trackBar_aggression.Maximum = 100;
            this.trackBar_aggression.Minimum = 1;
            this.trackBar_aggression.Name = "trackBar_aggression";
            this.trackBar_aggression.Size = new System.Drawing.Size(426, 45);
            this.trackBar_aggression.TabIndex = 15;
            this.trackBar_aggression.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_aggression.Value = 10;
            this.trackBar_aggression.ValueChanged += new System.EventHandler(this.trackBar_agression_ValueChanged);
            // 
            // label_agression
            // 
            this.label_agression.AutoSize = true;
            this.label_agression.Location = new System.Drawing.Point(269, 27);
            this.label_agression.Name = "label_agression";
            this.label_agression.Size = new System.Drawing.Size(13, 13);
            this.label_agression.TabIndex = 17;
            this.label_agression.Text = "?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_maxVal);
            this.groupBox2.Controls.Add(this.trackBar_maxVal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label_minVal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.trackBar_minVal);
            this.groupBox2.Controls.Add(this.groupBox_led_brightness);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label_agression);
            this.groupBox2.Controls.Add(this.trackBar_aggression);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 224);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Light preferences";
            // 
            // label_maxVal
            // 
            this.label_maxVal.AutoSize = true;
            this.label_maxVal.Location = new System.Drawing.Point(305, 152);
            this.label_maxVal.Name = "label_maxVal";
            this.label_maxVal.Size = new System.Drawing.Size(13, 13);
            this.label_maxVal.TabIndex = 27;
            this.label_maxVal.Text = "?";
            // 
            // trackBar_maxVal
            // 
            this.trackBar_maxVal.Location = new System.Drawing.Point(221, 168);
            this.trackBar_maxVal.Maximum = 255;
            this.trackBar_maxVal.Name = "trackBar_maxVal";
            this.trackBar_maxVal.Size = new System.Drawing.Size(212, 45);
            this.trackBar_maxVal.TabIndex = 26;
            this.trackBar_maxVal.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_maxVal.Value = 255;
            this.trackBar_maxVal.ValueChanged += new System.EventHandler(this.track_maxVal_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Max brightness:";
            // 
            // label_minVal
            // 
            this.label_minVal.AutoSize = true;
            this.label_minVal.Location = new System.Drawing.Point(90, 152);
            this.label_minVal.Name = "label_minVal";
            this.label_minVal.Size = new System.Drawing.Size(13, 13);
            this.label_minVal.TabIndex = 24;
            this.label_minVal.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Min brightness:";
            // 
            // trackBar_minVal
            // 
            this.trackBar_minVal.Location = new System.Drawing.Point(7, 168);
            this.trackBar_minVal.Maximum = 255;
            this.trackBar_minVal.Name = "trackBar_minVal";
            this.trackBar_minVal.Size = new System.Drawing.Size(212, 45);
            this.trackBar_minVal.TabIndex = 22;
            this.trackBar_minVal.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_minVal.ValueChanged += new System.EventHandler(this.track_minVal_ValueChanged);
            // 
            // groupBox_led_brightness
            // 
            this.groupBox_led_brightness.Controls.Add(this.panel_led_brightness);
            this.groupBox_led_brightness.Location = new System.Drawing.Point(9, 94);
            this.groupBox_led_brightness.Name = "groupBox_led_brightness";
            this.groupBox_led_brightness.Size = new System.Drawing.Size(424, 43);
            this.groupBox_led_brightness.TabIndex = 20;
            this.groupBox_led_brightness.TabStop = false;
            this.groupBox_led_brightness.Text = "LED Brightness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Aggression (how fast/smooth light respond to sound):";
            // 
            // checkBox_start_with_windows
            // 
            this.checkBox_start_with_windows.AutoSize = true;
            this.checkBox_start_with_windows.Location = new System.Drawing.Point(459, 292);
            this.checkBox_start_with_windows.Name = "checkBox_start_with_windows";
            this.checkBox_start_with_windows.Size = new System.Drawing.Size(173, 17);
            this.checkBox_start_with_windows.TabIndex = 19;
            this.checkBox_start_with_windows.Text = "Start with Windows / minimized";
            this.checkBox_start_with_windows.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 63);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1288, 125);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Child = this.spectrum1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 427);
            this.Controls.Add(this.checkBox_start_with_windows);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.comboBox_soundcard_list);
            this.Controls.Add(this.trackBar_high_ch);
            this.Controls.Add(this.trackBar_low_ch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LED Ambient light controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_low_ch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_high_ch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_aggression)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_maxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_minVal)).EndInit();
            this.groupBox_led_brightness.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.ComboBox comboBox_soundcard_list;
        private System.Windows.Forms.Timer timer1;
        private Spectrum spectrum1;
        private System.Windows.Forms.TrackBar trackBar_low_ch;
        private System.Windows.Forms.TrackBar trackBar_high_ch;
        private System.Windows.Forms.Panel panel_led_brightness;
        private System.Windows.Forms.CheckBox checkBox_enabled;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TrackBar trackBar_aggression;
        private System.Windows.Forms.Label label_agression;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_led_brightness;
        private System.Windows.Forms.Label label_maxVal;
        private System.Windows.Forms.TrackBar trackBar_maxVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_minVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar_minVal;
        private System.Windows.Forms.CheckBox checkBox_start_with_windows;
        private System.Windows.Forms.Timer timer2;
    }
}

