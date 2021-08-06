using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList name = new ArrayList();
        ArrayList tc = new ArrayList();
        ArrayList age = new ArrayList();
        ArrayList phoneNo = new ArrayList();
        ArrayList wage= new ArrayList();

        private void button9_Click(object sender, EventArgs e)
        {
            listBox6.Items.Add("No".PadRight(5, ' ') + "Ad Soyad".PadRight(16, ' ') + "Tc".PadRight(14, ' ') +"Yaş".PadRight(4,' ') + "Tel".PadRight(13, ' ') + "Maaş");
            for (int i = 0; i < name.Count; i++)
            {
                listBox6.Items.Add((i+1).ToString().PadRight(5, ' ') + name[i].ToString().PadRight(16, ' ') 
                 + tc[i].ToString().PadRight(14, ' ')    + age[i].ToString().PadRight(5, ' ')    + phoneNo[i].ToString().PadRight(12, ' ') 
                    + wage[i].ToString()+" TL");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            listBox6.Items.Clear();
            name.Add(textBox2.Text);
            tc.Add(textBox3.Text);
            age.Add(textBox4.Text);
            phoneNo.Add(textBox5.Text);
            wage.Add(textBox6.Text);
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox2.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox6.Items.Remove(listBox6.SelectedItem);
        }
    }
}
