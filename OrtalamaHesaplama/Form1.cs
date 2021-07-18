using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int not1,not2,not3 ;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                not1 = Convert.ToInt32(textBox1.Text);
                if (not1<0||not1>100)
                {
                    MessageBox.Show("HATALI GİRİŞ YAPILDI");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                   


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox2.Text != "") 
            {
                not2 = Convert.ToInt32(textBox2.Text);
                if (not2 < 0 || not2 > 100)
                {
                    MessageBox.Show("HATALI GİRİŞ YAPILDI");
                    textBox2.Text = "";
                    textBox2.Focus();
                }



            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox3.Text != "") 
            {
                not3 = Convert.ToInt32(textBox3.Text);
                if (not3 < 0 || not3 > 100)
                {
                    MessageBox.Show("HATALI GİRİŞ YAPILDI");
                    textBox3.Text = "";
                    textBox3.Focus();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        double ortalama;
        private void button1_Click(object sender, EventArgs e)
        {
            ortalama=(not1+not2+not3)/3.00;
            label4.Text = "Ortalam : " + ortalama.ToString("n2");
            if (ortalama < 50) label5.Text = "KALDI";else if (ortalama >= 50 &&ortalama<60) label5.Text = "GEÇER"; else if (ortalama >= 60 && ortalama < 70) label5.Text = "ORTA"; else if (ortalama >= 70 && ortalama < 85) label5.Text = "İYİ"; else if (ortalama >= 85 && ortalama <= 100) label5.Text = "PEKİYİ";
        }
    }
}
