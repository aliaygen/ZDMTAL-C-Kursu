using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
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
        int number,numbers;
        string kind;
        private void button1_Click(object sender, EventArgs e)
        {
            numbers = Convert.ToInt32(textBox1.Text);
            for (int s = 1; s < numbers; s++)
            {
                number = s;
                if (number < 2)
                {
                    kind = "Sayı asal değildir";


                }
                else
                {
                    kind = "Sayı asaldır";
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            kind = "sayı asal değildir";
                            break;

                        }


                       // listBox1.Items.Add(i+" : " + kind);
                    }
                   
                }
                listBox1.Items.Add(s + " : " + kind);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        int number1, number2, conclusion=1;
        private void button2_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(textBox2.Text);
            number2 = Convert.ToInt32(textBox3.Text);

            for (int i = 0; i < number2; i++)
            {
                conclusion *= number1;
            }
            label6.Text = "Sonuç : " + conclusion.ToString("n2");
        }
    }
}
