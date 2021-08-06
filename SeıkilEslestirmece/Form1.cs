using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeıkilEslestirmece
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Parca
        {
            public int number;
            public Button button;
        }
        Parca[] parcalar ;
        Random random = new Random();
        int control = 0, ilkSayı = 1, ikinciSayı = 1, dogru = 24, time = 0,bol=14, timepuan = 60,puan = 0,seviye=1,sekilSay= 16,total=0,bölüTakip=8,siraSec=4;
        Button ButtonYap( int width, int height, int x, int y,string text ,Color color,int tag,string font,int boyut)
        {
            Button button = new Button
            {
                Width = width,
                Height = height,
                Text = text,
                
                Font = new Font(font, boyut),
                Location = new Point(x, y),
                BackColor = color,
                Tag=tag

            };
            button.Click += Button_Click;
            this.Controls.Add(button);
            return button;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label2.Text = "süre : " + time;
            if (timepuan > 1) timepuan--;
        }

        void Mix(Parca[] parca)
        {
            int temp = 0, number1, number2;
            for (int i = 0; i < parca.Length; i++)
            {
                number1 = random.Next(parca.Length);
                number2 = random.Next(parca.Length);
                temp = parca[number1].number;
                parca[number1].number = parca[number2].number;
                parca[number2].number = temp;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (control == 0)
            {
                ilkSayı = ((int)(sender as Control).Tag);
                control = 1;
                parcalar[ilkSayı].button.Enabled = false;
                parcalar[ilkSayı].button.Text = parcalar[ilkSayı].number.ToString();
            }
            else
            {
                control = 0;
                ikinciSayı = ((int)(sender as Control).Tag);
                parcalar[ikinciSayı].button.Text = parcalar[ikinciSayı].number.ToString();
                if (parcalar[ilkSayı].number== parcalar[ikinciSayı].number)
                {
                    parcalar[ilkSayı].button.BackColor = Color.MediumSpringGreen;
                    parcalar[ikinciSayı].button.BackColor = Color.MediumSpringGreen;
                    parcalar[ilkSayı].button.Enabled = false;
                    parcalar[ikinciSayı].button.Enabled = false;
                    // dogru += 1;
                    puan += 3;
                    label1.Text = "Puan : " + puan;
                    if (puan>=dogru)
                    {
                        timer1.Stop();
                        puan += timepuan;
                        total += puan;
                        if (seviye>=4)
                        {
                            MessageBox.Show("oyun bitti\nPuan : " + total + "\ntekrar bekleriz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Exit();
                        }
                        else
                        {
                            DialogResult cvp;
                            cvp= MessageBox.Show("oyun bitti\nPuan : " + total + "\ndevam etmek istermisiniz", "uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                            if (cvp==DialogResult.Yes)
                            {
                                seviye++;
                                button1.Visible = true;
                                button1.Text = seviye + ". seviye\nBAŞLA";
                                sekilSay += bol;
                                bol += 4;
                                siraSec += 2;
                                bölüTakip = (sekilSay / 2);
                                dogru = (sekilSay/2)*3 ;
                                while (this.Controls.Count > 4)
                                {
                                    this.Controls[4].Dispose();
                                }

                            }
                            else if (cvp== DialogResult.Cancel)
                            {
                                button1.Visible = true;
                                button1.Text = seviye + ". seviye\nBAŞLA";
                                while (this.Controls.Count > 4)
                                {
                                    this.Controls[4].Dispose();
                                }
                            }
                            else
                            {
                                MessageBox.Show("oyun bitti\nPuan : " + total + "\ntekrar bekleriz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Application.Exit();
                            }
                        }
                    }
                }
                else
                {
                    parcalar[ilkSayı].button.Enabled = true;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(800);
                    Application.DoEvents();
                    parcalar[ikinciSayı].button.Text = "";
                    parcalar[ilkSayı].button.Text = "";

                }

            }
           /* if (dogru>=8)
            {
                while (this.Controls.Count > 1)
                {
                    this.Controls[1].Dispose();
                }
                MessageBox.Show("tebrikleeeeer", "oyun bitti");
                button1.Visible = true;
                dogru = 0;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parcalar = new Parca[sekilSay];
            puan = 0;
            time = 0;
            timepuan = 60;
            label2.Text = "Süre : " + time;
            label1.Text = "Puan : " + puan;
            label3.Text = "Level : " + seviye;
            int x = 10, y = 10, no = 1;
            button1.Visible = false;
            for (int i = 0; i < parcalar.Length; i++)
            {
                parcalar[i] = new Parca();
                if (i <bölüTakip) parcalar[i].number = (i + 1);
                else
                {
                    parcalar[i].number = no;
                    no++;
                }
                parcalar[i].button = ButtonYap(70, 70, x, y, "", Color.SkyBlue, i, "Comic Sans MS", 16);
                x += 75;
                if ((i+1)%siraSec ==0)
                {
                    x = 10;
                    y += 75;
                }
            }
            Mix(parcalar);
            timer1.Start();

        }
    }
}
