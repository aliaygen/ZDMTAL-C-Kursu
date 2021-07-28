using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void Press()
        {
            button1.Visible = true;
            button1.Text = "BASMA";
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Black;
            button1.Visible = true;
        }
        void NoPress()
        {
            button1.Visible = true;
            button1.Text = "BAS";
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Visible = true;
        }
         void None()
        {
            button1.Visible = false;
        }
        Random random = new Random();
        int number = 0, puan = 0, time = 0,temporaryPuan=-1000,item;
        string name, temporaryName;

        private void timer1_Tick(object sender, EventArgs e)
        {
             number = random.Next(3);
            if (number == 0)
            {

                None();

            }
            else if (number == 1)
            {

                Press();
            }
            else if (number == 2)
            {

                NoPress();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number==1)
            {
                puan -= 3;
                label1.Text = "Puan : " + puan;
            }
            else if (number == 2)
            {
                puan += 5;
                label1.Text = "Puan : " + puan;
                number = random.Next(2);
                if (number == 0) NoPress();
                else None();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                comboBox1.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = "Süre : " + time;
            progressBar1.Value = time;
            if (time<=0)
            {
                listBox3.Items.Clear();
                timer1.Stop();
                timer2.Stop();
                comboBox1.Enabled = true;
                button2.Enabled = true;
                label1.Text = "";
                label2.Text = "";
                button1.Visible = false;
                listBox2.Items.Add(puan);
                for (int s = 0; s < 2; s++)
                {
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        item = Convert.ToInt32(listBox2.Items[i]);
                        if (item > temporaryPuan)
                        {
                            temporaryPuan = item;
                            name = listBox1.Items[i].ToString();
                            listBox3.Items.Add(name +" : "+ temporaryPuan);
                            //listBox1.Items.RemoveAt(i);
                            //listBox2.Items.RemoveAt(i);

                        }
                     
                    }
                }

                
                label3.Text = "OYUN BİTTİ\nSKORUN : " + puan+"\n Max Skor "+name+" : "+temporaryPuan;
                
                
                textBox1.Enabled = true;
                textBox1.Clear();
                textBox1.Focus();
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puan = 0;
            label3.Text = "";
            time = Convert.ToInt16(comboBox1.Text);
            time = time * 10;
            timer1.Start();
            timer2.Start();
            comboBox1.Enabled = false;
            button2.Enabled = false;
            progressBar1.Maximum = time;
            progressBar1.Value = time;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            temporaryName = textBox1.Text;
            listBox1.Items.Add(temporaryName);
            
            textBox1.Enabled = false;


        }
    }
}
