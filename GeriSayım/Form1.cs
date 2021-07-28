using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriSayım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat , dakika , saniye,bar,santop,sd,ds,dktop;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saat == 0 && dakika == 0 && saniye == 0)
            {
                label2.Text = "BİTTİ";

               
                timer1.Stop();

            }
           
            
            progressBar1.Value = santop;
            santop--;
            if (saniye == 00)
            {   
                
                if (saat == 0 && dakika == 0 && saniye == 0)
                {
                    label2.Text = "BİTTİ";
                    
                    
                    timer1.Stop();
                    
                }
                
                
                if (dakika == 00&&saniye==00) 
                {
                    if (saat == 0 && dakika == 0 && saniye == 0)
                    {
                        label2.Text = "BİTTİ";
                       

                         
                        timer1.Stop();
                       
                    }
                    
                   
                    if (saat==0&&dakika==00&&saniye==00)
                    {
                        if (saat == 0 && dakika == 0 && saniye == 0)
                        {
                            label2.Text = "BİTTİ";
                            
                        
                            timer1.Stop();
                            
                        }
                        

                    }
                    dakika = 60;
                    saat--;
                }
                saniye = 60;
                dakika--;

            }
            saniye--;

            if (saat>=00&&dakika>=00&&saniye>=00)
            {
              label1.Text = string.Format("{0:D2}", saat) + ":" + string.Format("{0:D2}", dakika) + ":" + string.Format("{0:D2}", saniye);
            }
           


        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

                saat = Convert.ToInt32(comboBox1.Text);
                dakika = Convert.ToInt32(comboBox2.Text);
                saniye = Convert.ToInt32(comboBox3.Text);
                timer1.Start();
                sd = saat * 60;
            dktop = dakika + sd;
            ds = dktop * 60;
            santop = saniye + ds;
            progressBar1.Maximum = santop;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Value = santop;
            label2.Text = "";
            
        }
    }
}
