using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGame
{
    public partial class Form1 : Form
    {
        Button[] buttons = new Button[49];
        Random random = new Random();
        int number = 0, TempNumber = 0,puan;
        public Form1()
        {
            InitializeComponent();
        }
        Button ButtonYap(int width, int height, string text, int x, int y, Color color, int tag)
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
            if ((sender as Control).BackColor == Color.GreenYellow)
            {
                puan += 5;
            }
            else puan -= 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 100, y = 100;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = ButtonYap(40, 40, "", x, y, Color.DarkRed, (i + 1));
                x += 50;
                if ((i+1)%7==0)
                {
                    x = 100;
                    y += 50;
                    
                }
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            buttons[TempNumber].BackColor = Color.DarkRed;
            number = random.Next(49) ;
            buttons[number].BackColor = Color.GreenYellow;
            TempNumber = number;
            label1.Text = "Puan : " + puan;
        }
    }
}
