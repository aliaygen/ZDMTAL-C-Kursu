using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int[] numbers = new int[20];
        string result = "", lister = "";
       

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                listBox2.Items.Add(numbers[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                listBox3.Items.Add(numbers[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Array.Clear(numbers, 0, numbers.Length);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label4.Text = "---";
            label5.Text = "---";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox5.Items.Clear();
                listBox4.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            int number1,number2;
            string tampName;
            string[] names = new string[listBox4.Items.Count];
           

            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                names[i] = listBox4.Items[i].ToString();
            }
            for (int i = 0; i < 100; i++)
            {
                number1 = random.Next(names.Length);
                number2 = random.Next(names.Length);

               

                tampName = names[number1];
                names[number1] = names[number2];
                names[number2] = tampName;
            }
            for (int i = 0; i < names.Length; i++) 
            {
                listBox5.Items.Add((i + 1).ToString().PadRight(6, ' ') + names[i]);
            }
            listBox4.Items.Clear();




        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox4.Items.Remove(listBox4.SelectedItem);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = { "selin", "beyto", "kemal", "hale", "nur" };
            for (int i = 0; i < names.Length; i++)
            {
                result += " " + names[i];

            }
            Array.Sort(names);
            for (int i = 0; i < names.Length; i++)
            {
                lister += " " + names[i];

            }
            label4.Text = result;
            label5.Text = lister;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100, 1000);
                listBox1.Items.Add(numbers[i]);
            }
        }
    }
}
