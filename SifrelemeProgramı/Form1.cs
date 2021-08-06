using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifrelemeProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Sifrele(string metin)
        {
            Random random = new Random();
            int randomSayı = random.Next(1, 4);
            string sonuc = "";
            if (metin != "")
            {
                if (randomSayı == 1)
                {
                    foreach (char item in metin)
                    {
                        if (item < 50) sonuc += ((char)((int)item + 10)).ToString();
                        else sonuc += ((char)((int)item - 5)).ToString();

                    }
                    sonuc = "₺" + sonuc;
                }

                if (randomSayı == 2)
                {
                    foreach (char item in metin)
                    {
                        if (item < 50) sonuc += ((char)((int)item + 20)).ToString();
                        else sonuc += ((char)((int)item - 10)).ToString();
                    }
                    sonuc += "₺";
                }

                if (randomSayı == 3)
                {
                    foreach (char item in metin)
                    {
                        if (item < 50) sonuc += ((char)((int)item + 30)).ToString();
                        else sonuc += ((char)((int)item - 15)).ToString();
                    }
                    sonuc += "$";
                }
            }
            return sonuc;
        }
        string SifreCozum(string metin)
        {
            int randomSayı=0;
            string sonuc = "";
            if (metin != "")
            {
                if (metin.Substring(0, 1) == "₺")
                {
                    randomSayı = 1;
                    metin = metin.Remove(0, 1);
                }
                else if (metin.Substring(metin.Length - 1, 1) == "₺")
                {
                    randomSayı = 2;
                    metin = metin.Remove(metin.Length - 1, 1);

                }
                else if (metin.Substring(metin.Length - 1, 1) == "$")
                {
                    randomSayı = 3;
                    metin = metin.Remove(metin.Length - 1, 1);
                }


                if (randomSayı == 1)
                {
                    foreach (char item in metin)
                    {
                        if (item < 60) sonuc += ((char)((int)item - 10)).ToString();
                        else sonuc += ((char)((int)item + 5)).ToString();

                    }
                }

                if (randomSayı == 2)
                {
                    foreach (char item in metin)
                    {
                        if (item < 70) sonuc += ((char)((int)item - 20)).ToString();
                        else sonuc += ((char)((int)item + 10)).ToString();
                    }
                }

                if (randomSayı == 3)
                {
                    foreach (char item in metin)
                    {
                        if (item < 80) sonuc += ((char)((int)item - 30)).ToString();
                        else sonuc += ((char)((int)item + 15)).ToString();
                    }
                }
            }
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Sifrele(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;

            label1.Text = SifreCozum(textBox3.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
        }
    }
}
