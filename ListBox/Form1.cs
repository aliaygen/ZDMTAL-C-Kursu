using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random Random = new Random();
        int number,k1,k2,k3,k4,k5,numbers;

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                numbers = Convert.ToInt32(listBox3.Items[0]);
                if (numbers % 2 == 0) listBox6.Items.Add(numbers);
                else listBox5.Items.Add(numbers);
                listBox3.Items.Remove(numbers);
                

                
            }
        }

        string writing ="";
        
        private void button1_Click(object sender, EventArgs e)
        {
            number = Random.Next(10,100);
            listBox1.Items.Add("***** : " + number);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = Random.Next();
            for (int i = 1; i < 21; i++)
            {
                number = Random.Next(20,101);
                int s1 = Random.Next(2);
                if (s1 == 0) k1 = Random.Next(65, 91);
                else k1 = Random.Next(97, 123);

                int s2 = Random.Next(2);
                if (s2 == 0) k2 = Random.Next(65, 91);
                else k2 = Random.Next(97, 123);

                int s3 = Random.Next(2);
                if (s3 == 0) k3 = Random.Next(65, 91);
                else k3 = Random.Next(97, 123);

                int s4 = Random.Next(2);
                if (s4 == 0) k4 = Random.Next(65, 91);
                else k4 = Random.Next(97, 123);

                int s5 = Random.Next(2);
                if (s5 == 0) k5 = Random.Next(65, 91);
                else k5 = Random.Next(97, 123);

                writing = Convert.ToString((char)k1)+Convert.ToString((char)k2)+ Convert.ToString((char)k3)+ Convert.ToString((char)k4)+ Convert.ToString((char)k5);
                listBox2.Items.Add(i);
                listBox3.Items.Add(number);
                listBox4.Items.Add(writing);
            }
            
            

        }
    }
}
