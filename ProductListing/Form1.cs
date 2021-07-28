using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductListing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        int number;
        string text;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                number = Convert.ToInt32(textBox1.Text);
            }
           
            text = "";
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox1.Focus();
           
            for (int s = 0; s < number; s++)
            {
                text += "*";
                listBox1.Items.Add(text);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int c = 32; c < 127; c++)
            {
                listBox2.Items.Add(c + ":" + ((char)c).ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string a = textBox2.Text;
            for (int i = 0; i < a.Length; i++)
            {
                listBox3.Items.Add(a.Substring(i, 1).ToString());
            }
        }
    }
}
