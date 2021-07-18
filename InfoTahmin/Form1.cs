using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte girilenSayı ,kalanHak=5,sayı;

        private void Form1_Load(object sender, EventArgs e)
        {
            sayı = (byte)random.Next(10, 51);
            //kalanHak = 5;
            textBox1.Focus();
            label4.Text = sayı.ToString();
        }

        Random random = new Random();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        int puan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                if (kalanHak >= 1)
                {
                    girilenSayı = Convert.ToByte(textBox1.Text);
                    label3.ForeColor = Color.Black;

                    if (girilenSayı < sayı && girilenSayı > 9)
                    {
                        label3.Text = "büyük sayı giriniz";
                        kalanHak--;
                        if (kalanHak==0)
                        {

                            label4.Text = "Bulamadınız";
                            this.BackColor = Color.Pink;
                            if (puan >= 5) puan = puan - 5;


                            if (MessageBox.Show("CEVAP : " + sayı + "   oyuna devam etmek istermisiniz", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                kalanHak = 6;
                                textBox1.Text = "";
                                textBox1.Focus();
                                this.BackColor = Color.White;
                                sayı = (byte)random.Next(10, 51);
                                label3.Text = "...";
                                label4.Text = "...";
                                label5.Text = "Kalan Hak : " + kalanHak;


                            }
                            else
                            {
                                Application.Exit();
                            }
                        }

                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else if (girilenSayı > sayı && girilenSayı < 51)
                    {
                        label3.Text = "küçük sayı giriniz";
                        kalanHak--;
                        if (kalanHak == 0)
                        {

                            label4.Text = "Bulamadınız";
                            this.BackColor = Color.Pink;
                            if (puan >= 5) puan = puan - 5;


                            if (MessageBox.Show("CEVAP : " + sayı + "   oyuna devam etmek istermisiniz", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                kalanHak = 6;
                                textBox1.Text = "";
                                textBox1.Focus();
                                this.BackColor = Color.White;
                                sayı = (byte)random.Next(10, 51);
                                label3.Text = "...";
                                label4.Text = "...";
                                label5.Text = "Kalan Hak : " + kalanHak;


                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else if (girilenSayı == sayı)
                    {
                        label4.Text = "buldunuz";
                        this.BackColor = Color.LightGreen;
                        puan = (kalanHak*5)+puan;

                        if (MessageBox.Show("oyuna devam etmek istermisiniz", "oyun bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            kalanHak = 4;
                            textBox1.Text = "";
                            textBox1.Focus();
                            this.BackColor = Color.White;
                            sayı = (byte)random.Next(10, 51);
                            label3.Text = "...";
                            label4.Text = "...";
                            label5.Text = "Kalan Hak : "+ kalanHak;
                        }
                        else
                        {
                            Application.Exit();
                        }

                    }
                    else if (girilenSayı<=9 || girilenSayı>=51)
                    {
                        label3.Text = "HATALI SAYI";
                        label3.ForeColor = Color.Red;
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    
                    
                    
                    label5.Text = "Kalan Hak : " + kalanHak;
                    label2.Text = "PUAN : " + puan;
                }
               
                

            }           
        }
    }
}
