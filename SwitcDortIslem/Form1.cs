using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitcDortIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayı1, sayı2, sonuc ;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "") button1.Visible = true;
            else button1.Visible = false;
        }

        string ıslem;
        private void button1_Click(object sender, EventArgs e)
        {
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            ıslem = comboBox1.Text;
            switch (ıslem)
            {
                case "+" : sonuc = sayı1 + sayı2; break;
                case "-": sonuc = sayı1 - sayı2; break;
                case "*": sonuc = sayı1 * sayı2; break;
                case "/": sonuc = sayı1 / sayı2; break;

                default:label3.Text = "HATALI İŞLEM TALEBİ";
                    break;
            }
            label3.Text = "SONUÇ : " + sonuc.ToString("N2");
        }
    }
}
