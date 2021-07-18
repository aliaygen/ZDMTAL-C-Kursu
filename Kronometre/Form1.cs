using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat =0 , dakika=0, saniye=0, milisaniye=0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            milisaniye++;
            if (milisaniye==100)
            {
                milisaniye = 0;
                saniye++;
            }
            if (saniye==60)
            {
                milisaniye = 0;
                saniye = 0;
                dakika++;
            }
            if (dakika==60)
            {
                milisaniye = 0;
                saniye = 0;
                dakika=0;
                saat++;
            }
            label1.Text = string.Format("{0:D2}", saat) + ":" + string.Format("{0:D2}", dakika) + ":" + string.Format("{0:D2}", saniye) + ":" + string.Format("{0:D2}", milisaniye);
        }
    }
}
