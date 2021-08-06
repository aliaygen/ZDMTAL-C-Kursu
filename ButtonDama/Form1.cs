using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonDama
{
    public partial class Form1 : Form
    {
        int xDeger, yDeger;
        public Form1()
        {
            InitializeComponent();
        }
        void ButtonDamaOlustur (Button button, int width, int height, int x, int y, Color color)
        {
            button = new Button
            {
                Width = width,
                Height = height,
                Location = new Point(x, y),
                BackColor = color
            };
            this.Controls.Add(button);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xDeger = 100;
            yDeger = 100;
            Button[,] buttons = new Button[7, 7];
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    if ((i+j)%2==0) ButtonDamaOlustur(buttons[i, j], 50, 50, xDeger, yDeger, Color.Black);
                    else ButtonDamaOlustur(buttons[i, j], 50, 50, xDeger, yDeger, Color.White);
                    xDeger += 50;
                }
                yDeger += 50;
                xDeger = 100;

            }
        }
    }
}
