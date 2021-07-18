using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İfElse
{
    public partial class Form1 : Form
    {    
        double gunUcret,calisGun,vergi,cocukYardımı,netKazanc,kazanc;
        int dogumYili, cocukSayisi;
        string adi;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cocukSayisi = 0;
            adi = textBox1.Text;
            gunUcret = Convert.ToDouble(textBox2.Text);
            calisGun = Convert.ToDouble(textBox3.Text);
            dogumYili = Convert.ToInt16(textBox4.Text);
            if (comboBox1.Visible == true) cocukSayisi = Convert.ToInt16(comboBox1.Text);

            kazanc = gunUcret * calisGun;
            cocukYardımı = cocukSayisi * 80;
            if (dogumYili >= 1920 && dogumYili <= 2003) vergi = kazanc * 0.05;
            else vergi = kazanc * 0.10;
            netKazanc = kazanc + cocukYardımı - cocukYardımı;

            label5.Text = "Adı Soyadı : " + adi;
            label6.Text = "Kazanç : " + kazanc.ToString("n2");
            label7.Text = "Vergi : " + vergi.ToString("n2");
            label8.Text = "Çocuk Yardımı : " + cocukYardımı.ToString("n2");
            label9.Text = "Net Kazanç : " + netKazanc.ToString("n2");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label10.Visible = true;
                comboBox1.Visible = true;

            }
            else
            {
                label10.Visible = false;
                comboBox1.Visible = false;
            } 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                dogumYili = Convert.ToInt16(textBox4.Text);

                if (dogumYili >= 1920 && dogumYili <= 2003) checkBox1.Visible = true;
                else checkBox1.Visible = false;

            }
        }
    }
}
