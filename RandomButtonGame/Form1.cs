using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomButtonGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int number, numbers;
        public Form1()
        {
            InitializeComponent();
        }
        Button ButtonYap(int width, int height, string text, int x, int y, Color color,int tag)
        {
            Button button = new Button();
            button.Text = text;
            button.Width = width;
            button.Height = height;
            button.Location = new Point(x, y);
            button.BackColor = color;
            button.Tag = tag;
            this.Controls.Add(button);
            button.Click += Button_Click;
            return button;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((int)((sender as Control).Tag) == number) MessageBox.Show("tmm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (this.Controls.Count>3)
            {
                this.Controls[3].Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 100; i++)
            {

                int w = random.Next(ClientSize.Height), h = random.Next(ClientSize.Height), x = random.Next(ClientSize.Width - 20), y = random.Next(ClientSize.Height - 20);
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                ButtonYap(30,30, (i+1).ToString(), x, y, color,i);
            }
            number = random.Next(20);
            label1.Text = number.ToString();


        }
    }
}
