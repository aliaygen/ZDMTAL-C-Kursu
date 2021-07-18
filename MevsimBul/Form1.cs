using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MevsimBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label3.Text = "";
            label2.Text = "";
            panel1.BackColor = Color.White;
            textBox1.Focus();



            string no = textBox1.Text;

            if (no=="12" || no == "1" || no=="2")
            {
                panel1.BackColor = Color.LightSkyBlue;
                label2.Text = "Ay No : " + no;
                label3.Text = "Mevsim : Kış";

            }
            else if (no == "3" || no == "4" || no == "5")
            {
                panel1.BackColor = Color.LightGreen;
                label2.Text = "Ay No : " + no;
                label3.Text = "Mevsim : İlk Bahar";

            }
            else if (no == "6" || no == "7" || no == "8")
            {
                panel1.BackColor = Color.Yellow;
                label2.Text = "Ay No : " + no;
                label3.Text = "Mevsim : yaz";

            }
            else if (no == "9" || no == "10" || no == "11")
            {
                panel1.BackColor = Color.LemonChiffon;
                label2.Text = "Ay No : " + no;
                label3.Text = "Mevsim : Son Bahar";

            }
            else
            {
                label4.Text = "...HATA...";
                label4.ForeColor = Color.Red;
                panel1.BackColor = Color.Black;
            }
            textBox1.Text = "";
            textBox1.Focus();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
