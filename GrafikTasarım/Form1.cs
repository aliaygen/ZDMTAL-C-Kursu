using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikTasarım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Graphics graphics = this.CreateGraphics();
            Pen kalem = new Pen(Color.DeepSkyBlue,5);
            /*graphics.FillRectangle(Brushes.Red, 50, 50, 49, 49);
            Point point1 = new Point(100, 100);
            Point point2 = new Point(500, 400);
           
            graphics.FillPie(Brushes.Aqua, 150, 150, 300, 200, 0, -90);
            graphics.FillPie(Brushes.OrangeRed, 100, 100, 400, 300, 216, 54);
            graphics.FillPie(Brushes.Red, 100, 100, 400, 300, 90, 126);
            graphics.FillPie(Brushes.White, 150, 150, 300, 200, 90, 126);
            graphics.DrawLine(kalem, point1, point2);
            graphics.DrawRectangle(new Pen(Color.Green, 5), 100, 100, 400, 300);
            graphics.DrawEllipse(kalem, 100, 100, 400, 300);
            graphics.DrawLine(kalem, 300,100, 300, 400);
           
            graphics.DrawLine(kalem,150, 250, 450, 250);
           
            graphics.DrawEllipse(kalem, 150, 150, 300,200);*/

            for (int i = 0; i < ClientSize.Height; i+=10)
            {
                kalem = new Pen(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)),10);
                graphics.DrawLine(kalem, 0, i, ClientSize.Width, i);
            }
        }
    }
}
