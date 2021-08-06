using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Graphics graphics;
        Pen pen;
        string[] kelimeler = new string[] { "NALBUR", "KEMAN", "NEHİR", "BALİNA", "KELİME", "KİTAP", "GÖZLÜK", "SİNAMA", "PANEL", "KAMU", "MÜLAKAT", "KUŞ", "KALP", "ÇALIŞAN", "SENDİKA", "HUKUK", "BEYİN", "KUZU", "MAHLUKAT", "KAN", "GÜNEY" };
        string kelime;
        int uzunluk = 0;
        Char[] konturol;
        int puan = 0, kalan = 10;
        public Form1()
        {
            InitializeComponent();
        }
        void KlavyeYap(int width, int height, string text, int x, int y, Color color, int tag)
        {
            Button button = new Button();
            button.Width = width;
            button.Height = height;
            button.Text = text;
            button.Location = new Point(x, y);
            button.BackColor = color;
            button.Tag = tag;
            button.Click += Button_Click;
            this.Controls.Add(button);
        }
        string kelimeYap(string[] kelimeler)
        {
            int kelimeNo;
            kelimeNo = random.Next(kelimeler.Length);

            return kelimeler[kelimeNo];

        }
        void Labelyap(string text,int x,int y,int tag)
        {
            Label label = new Label();
            label.Font = new Font("Courier New",16);
            label.Text = text;
            label.ForeColor = Color.Black;
            label.AutoSize = true;
            label.Location = new Point(x, y);
            label.Tag = tag;
            this.Controls.Add(label);
        }
        void Bittir(string sonuc)
        {
            while (this.Controls.Count > 2)
            {
                this.Controls[2].Dispose();
            }
            MessageBox.Show(sonuc+"\ndoğru cevap : "+kelime, "OYUN BİTTİ");
            puan = 0;
            kalan = 10;
            uzunluk = 0;
            graphics.Clear(this.BackColor);
        }
        char[] HarfAyır(string kelime)
        {
            int x = 60, y = 200;
            Char[] harfler = new Char[kelime.Length];
            for (int i = 0; i < kelime.Length; i++)
            {
                harfler[i] = (char)kelime[i];
            }
            for (int i = 0; i < harfler.Length; i++)
            {
                Labelyap(((char)175).ToString(),x,y,i);
                x += 30;
            }
           // label1.Text = kelime;
            return harfler;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            bool k = false;
            
            for (int i = 0; i<konturol.Length; i++)
            {
                if ((sender as Control).Text == konturol[i].ToString())
                {
                    (sender as Control).BackColor = Color.LightGreen;
                    (sender as Control).Enabled = false;
                    puan += 5;
                    uzunluk += 1;
                    Labelyap(konturol[i].ToString(), 60 + (30 * i), 170, (i * 2));
                    k= true;
                    
                }
               
            } if(k==false)
                {
                    (sender as Control).BackColor = Color.Red;
                    (sender as Control).Enabled = false;
                    kalan -= 1 ;
                switch (kalan)
                {
                    case 9:
                        graphics.DrawLine(new Pen (Color.Black,4), 500, 300, 700, 300);
                       // MessageBox.Show("");
                        break;
                    case 8:
                        graphics.DrawLine(new Pen(Color.Black, 4), 650, 300, 650, 50);
                        break;
                    case 7:
                        graphics.DrawLine(new Pen(Color.Black, 4), 652, 52, 548, 52);
                        break;
                    case 6: 
                        graphics.DrawLine(new Pen(Color.Black, 4), 550, 50, 550, 100);
                        break;
                    case 5:
                        graphics.DrawEllipse(new Pen(Color.Black, 4), 535, 100, 30 , 30);
                        break;
                    case 4:
                        graphics.DrawLine(new Pen(Color.Black, 4), 550, 130, 550, 210);
                        break;
                    case 3:
                        graphics.DrawLine(new Pen(Color.Black, 4), 550, 130, 525, 160);
                        break;
                    case 2:
                        graphics.DrawLine(new Pen(Color.Black, 4), 550, 130, 575, 160);
                        break;
                    case 1:
                        graphics.DrawLine(new Pen(Color.Black, 4), 550, 210, 525, 230);
                        break;
                    case 0:
                        graphics.DrawLine(new Pen(Color.Black, 4), 550, 210, 575, 230);
                        break;
                    default:
                        break;
                }
            }
            label1.Text = "kalan Hak : " + kalan;
            if (uzunluk>=kelime.Length)
            {
                Bittir("KAZANDIN");
                button1.Visible = true;
                
            }
            else if (kalan<=0)
            {
                Bittir("KAYBETTİN");
                button1.Visible = true;
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            pen = new Pen(Color.Black, 10);
            kelime = kelimeYap(kelimeler);
            konturol = new Char[kelime.Length];
            konturol= HarfAyır(kelime);
            int x=60, y=250,tag=1;
            Char[] Klavye = new Char[] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G','Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'Q', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'W', 'X', 'Y', 'Z' };
            foreach (var harf in Klavye)
            {
                KlavyeYap(30, 30, harf.ToString(), x, y, Color.Aqua, tag) ;
                x += 35;
                tag++;
                if (x > 400)
                {
                    x = 60;
                    y += 35;
                }
            }
            button1.Visible = false;
        }
    }
}
