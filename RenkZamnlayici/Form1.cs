using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenkZamnlayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayı= 0 ;
        Random renk = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "sayı : " + sayı;
            sayı++;
            string zaman = DateTime.Now.ToLongTimeString();
            label1.Text = zaman;
            panel1.BackColor = Color.FromArgb(renk.Next(256), renk.Next(256), renk.Next(256));
        }
    }
}
