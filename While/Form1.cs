using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number, randomNumber,numbers;
        bool add;

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listBox3.Items.Clear();

            do
            {
                add = true;
                numbers = random.Next(0, 100);
                foreach (int item in listBox3.Items)
                {
                    if (item == numbers) add = false;

                }
                if (add) listBox3.Items.Add(numbers);
            } while (numbers!=50);
            label1.Text = listBox3.Items.Count.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            number = 1;
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            do
            {
                randomNumber = random.Next(10, 100);
                listBox1.Items.Add(number);
                listBox2.Items.Add(randomNumber);
                number++;

            } while (number<=20);
        }
    }
}
