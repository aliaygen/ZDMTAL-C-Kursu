using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1, number2, total,average;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label5.Text = "...";
            label8.Text = "...";
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);
            if (number1 < number2)
            {
                for (double i = number1; i <= number2; i++)
                {
                    listBox1.Items.Add(i);
                    total += i;

                }
                average = total / (number2 - number1 + 1);
            }
            else if (number1 > number2) 
            {
                for (double i = number2; i <= number1; i++)
                {
                    listBox1.Items.Add(i);
                    total += i;

                }
                average = total / (number1 - number2 + 1);
            }
            label5.Text = Convert.ToString(total);
            label8.Text = Convert.ToString(average);

        }
    }
}
