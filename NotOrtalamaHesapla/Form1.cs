using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotOrtalamaHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, ortalama;
            not1 = Convert.ToDouble(textBox1.Text);
            not2 = Convert.ToDouble(textBox2.Text);
            not3 = Convert.ToDouble(textBox3.Text); 
            ortalama = (not1 + not2 + not3) / 3;

            label4.Text = "Ortalama" + ortalama.ToString("n2");
            if (ortalama >=50)
            {
                label5.Text = "GEÇTİN";
                this.BackColor = Color.LightGreen;

            }
            else
            {
                label5.Text = "KALDIN";
                this.BackColor = Color.Red;
            }

        }
    }
}
