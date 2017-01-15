using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioSpectrumAdvance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            analyzer = new Analyzer(progressBar1, progressBar2, spectrum1, comboBox1, chart1);
            analyzer.Enable = true;
            analyzer.DisplayEnable = true;

            

            timer1.Enabled = true;
        }
        Analyzer analyzer;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {




        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
