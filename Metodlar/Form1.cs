using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void NamePrint(string name)
        {
            MessageBox.Show("Merhaba " + name);
        }
        double Topla(double number1, double number2)
        {
            return number1 + number2;
        }
        decimal Faktoriel(byte number)
        {
            decimal sonuc = 1;
            for (int i = 1; i < number; i++) sonuc *= i;
            return sonuc;
        }
        string Asalmı(int number)
        {
            string sonuc;
            bool kontrol = true;
            for (int i = 2; i < number; i++)
            {

                if (number % i == 0) kontrol = false;

            }
            if (kontrol == true)
            {
                sonuc = number.ToString() + " = sayısı asaldır";
            }
            else sonuc = number.ToString() + " = sayısı asal değildir";
            return sonuc;
        }
        string Birlestir ( string[] dizi)
        {
            string sonuc="";
            foreach (var item in dizi)
            {
                sonuc += " , " + item;
            }
            return sonuc;
        }
        string SiraliBirlestir(string[] dizi)
        {
            int l = 0;
            string sonuc="";
            for (int i = 0; i < (dizi.Length/3); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sonuc += dizi[l].PadRight(25, ' ')+" ";
                    l++;
                }
                sonuc += "\n";
            }
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NamePrint(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = ("Sonuç " + Topla(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)).ToString("n2"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            byte number = byte.Parse(textBox4.Text);
            for (byte i = 1; i <= number; i++)
            {
                listBox1.Items.Add(i + "! = " + Faktoriel(i));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string sonuc;
            sonuc = Convert.ToString(Asalmı(int.Parse(textBox5.Text)));
            label4.Text = sonuc;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt32(textBox6.Text);
            for (int i = 2; i < number; i++)
            {

                listBox2.Items.Add(Asalmı(i));
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                listBox3.Items.Add(textBox7.Text);
                textBox7.Clear();
                textBox7.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox3.Items.Remove(listBox3.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] names = new string[listBox3.Items.Count];
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                names[i]= listBox3.Items[i].ToString();
            }
            label10.Text = Birlestir(names);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            string[] list = new string[listBox4.Items.Count];
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                list[i] = listBox4.Items[i].ToString();
            }

            label12.Text = SiraliBirlestir(list);
           

            
        }
    }
}
