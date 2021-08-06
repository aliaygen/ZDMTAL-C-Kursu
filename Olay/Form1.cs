using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void DamaPanel(Panel panel, int width, int height, int x, int y, Color color)
        {
            panel = new Panel
            {
                Width = width,
                Height = height,
                Location = new Point(x, y),
                BackColor = color
            };
            this.Controls.Add(panel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel1 = new Panel
            {
                Width = 100,
                Height = 100,
                BackColor = Color.LightGreen,
                Location = new Point(200, 00)
            };
            this.Controls.Add(panel1);

            Panel panel2 = new Panel
            {
                Width = 100,
                Height = 100,
                BackColor = Color.LightGreen,
                Location = new Point(400, 00)
            };
            this.Controls.Add(panel2);
            Panel panel3 = new Panel
            {
                Width = 100,
                Height = 100,
                BackColor = Color.LightGreen,
                Location = new Point(600, 00)
            };
            this.Controls.Add(panel3);

            Panel panel4 = new Panel
            {
                Width = 100,
                Height = 100,
                BackColor = Color.LightGreen,
                Location = new Point(800, 00)
            };
            this.Controls.Add(panel4);

            Panel panel5 = new Panel
            {
                Width = 100,
                Height = 100,
                BackColor = Color.LightGreen,
                Location = new Point(1000, 00)
            };
            this.Controls.Add(panel5);


            int left = 200, top = 200;


            Panel[] paneller = new Panel[5];
            for (int i = 0; i < paneller.Length; i++)
            {
                paneller[i] = new Panel();
                paneller[i].Width = 100;
                paneller[i].Height = 100;
                paneller[i].BackColor = Color.LightBlue;
                paneller[i].Left = left;
                paneller[i].Top = top;
                left += 110;
                this.Controls.Add(paneller[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int left = 200, top = 200;
            Panel[,] damaPanels = new Panel[8,8];
            for (int i = 0; i < damaPanels.GetLength(0); i++)
            {
                for (int j = 0; j < damaPanels.GetLength(1); j++)
                {
                    if ((i+j)%2==0)
                    {
                        DamaPanel(damaPanels[i, j], 20, 20, left, top,Color.White );
                    }
                    else DamaPanel(damaPanels[i, j], 20, 20, left, top,Color.Black);
                    left += 20;
                }
                top += 20;
                left = 200;
            }
        }
    }
}
