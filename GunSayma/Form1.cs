using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunSayma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;

            string no = textBox1.Text;
            if (no == "1") label2.Text = "Pazartesi";
            else if (no == "2") label2.Text = "Salı";
            else if (no == "3") label2.Text = "Çarşamba";
            else if (no == "4") label2.Text = "Perşembe";
            else if (no == "5") label2.Text = "Cuma";
            else if (no == "6") label2.Text = "Cumartesi";
            else if (no == "7") label2.Text = "Pazar";
            else
            {
                label2.Text = "...HATALI GİRİŞ...";
                label2.ForeColor = Color.Red;
            }
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
