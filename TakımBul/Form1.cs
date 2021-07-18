using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakımBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string takım;
        private void button1_Click(object sender, EventArgs e)
        {

            takım = comboBox1.Text;
            
            switch (takım)
            {
                case "GS":
                    label2.Text = "Galata Saray";
                    panel1.BackColor = Color.Yellow;
                    panel2.BackColor = Color.Red;
                    panel3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\gs.png");
                    panel3.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "FB":
                    label2.Text = "Fener Bahçe";
                    panel1.BackColor = Color.Yellow;
                    panel2.BackColor = Color.Navy;
                    panel3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\fb.png");
                    panel3.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "BJK":
                    label2.Text = "Beşiktaş";
                    panel1.BackColor = Color.Black;
                    panel2.BackColor = Color.White;
                    panel3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bjk.png");
                    panel3.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "TS":
                    label2.Text = "Trabzon Spor";
                    panel1.BackColor = Color.DarkRed;
                    panel2.BackColor = Color.Blue;
                    panel3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\ts.png");
                    panel3.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "BS":
                    label2.Text = "Bursa Spor";
                    panel1.BackColor = Color.Green;
                    panel2.BackColor = Color.White;
                    panel3.BackgroundImage = Image.FromFile(Application.StartupPath + "\\bs.png");
                    panel3.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")button1.Visible = true;
            else button1.Visible = false;

        }
    }
}
