using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listBox1.Items.Clear();
            if (textBox1.Text != "")
            {
                int piece = Convert.ToInt32(textBox1.Text);


                for (int i = 0; i < piece; i++)
                {
                    listBox1.Items.Add(random.Next(10, 100));
                }
            }
            listBox2.Items.Clear();
            listBox3.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (int item in listBox1.Items)
            {
                if (item % 2 == 0)
                {
                    listBox3.Items.Add(item);
                }
                else
                {
                    listBox2.Items.Add(item);
                }
                label4.Text = Convert.ToString(listBox2.Items.Count);
                label5.Text = listBox3.Items.Count.ToString();// İkiside aynı işlemi yapabiliyor .!!! Bu sadece string de mümkün
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listBox4.Items.Clear();
            int number, a1, a2, x;
            int piece = Convert.ToInt32(textBox2.Text);
            a1 = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Taban sayı gir", "Giriş"));
            a2 = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Tavan sayı gir", "Giriş"));
            bool add;
            x = Math.Abs(a1 - a2);
            if (piece >= x)
            {
                MessageBox.Show("Belirlenen Sınırların Dışında", "Hata", MessageBoxButtons.OK);
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                if (textBox2.Text != "")
                {

                    for (int i = 0; i < piece; i++)
                    {
                        add = true;
                        if (a1 < a2) number = random.Next(a1, a2);
                        else number = random.Next(a2, a1);
                        foreach (int item in listBox4.Items)
                        {
                            if (item == number)
                            {
                                add = false;
                                i--;
                            }
                        }
                        if (add) listBox4.Items.Add(number);
                    }
                    label8.Text = listBox4.Items.Count.ToString();
                }
            }

        }
    }
}
