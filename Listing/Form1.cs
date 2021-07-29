using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int Number, SchoolNo, taskNo, number1, number2, schoolNo1, schoolNo2;
        string name1, name2, name;
        Random Random = new Random();

        private void button2_Click(object sender, EventArgs e)
        {

            number1 = Random.Next(listBox1.Items.Count);
            do
            {
                number2 = Random.Next(listBox1.Items.Count);
            } while (number1 == number2);
            name1 = listBox2.Items[number1].ToString();
            name2 = listBox2.Items[number2].ToString();
            schoolNo1 = Convert.ToInt32(listBox3.Items[number1]);
            schoolNo2 = Convert.ToInt32(listBox3.Items[number2]);
            label5.Text = (number1 + 1).ToString() + " " + name1 + " " + schoolNo1;
            label6.Text = (number2 + 1).ToString() + " " + name2 + " " + schoolNo2;

        }

        bool add;

        private void button1_Click(object sender, EventArgs e)
        {
            Number = 0;
            taskNo = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                add = true;
                Number++;
                listBox1.Items.Add(Number);
                SchoolNo = Random.Next(100, 1000);
                foreach (int item in listBox3.Items)
                {

                    if (item == SchoolNo)
                    {
                        add = false;
                        i--;
                    }
                }
                if (add)
                {
                    listBox3.Items.Add(SchoolNo);
                    name = listBox2.Items[Number].ToString();
                    listBox5.Items.Add((Number).ToString().PadRight(5, ' ') + name.PadRight(26, ' ') + SchoolNo.ToString());


                }

                listBox4.Items.Add(taskNo);


            }

        }
    }
}
