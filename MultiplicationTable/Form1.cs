using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int s = 1; s <= 10; s++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    listBox1.Items.Add(s + " X " + i + " = " + s * i);
                }
                listBox1.Items.Add("_____________________________");
            }
        }
    }
}
