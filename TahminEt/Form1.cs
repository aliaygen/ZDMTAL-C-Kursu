using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TahminEt
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


                int sayı, girilenSayı;
            
            sayı = random.Next(11);
            girilenSayı = Convert.ToInt16(textBox1.Text);

            if (girilenSayı <=10 && girilenSayı >=0 )
            {
                if (sayı == girilenSayı)
                {
                    label3.Text = "TEBRİKLER Doğru Tahmin Ettiniz";

                }
                else
                {
                    label3.Text = "ÜZGÜNÜM Tahmin Edemediniz";
                }

            }
            else
            {
                label3.Text = "hatalı sayı girdiniz";
            }

            

        }
    }
}
