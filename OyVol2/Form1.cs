using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OyVol2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aPartisiOy, bPartisiOy, cPartisiOy, dPartisiOy, ePartisiOy, toplamOy
                 , aPartisiMilOy, bPartisiMilOy, cPartisiMilOy, dPartisiMilOy, ePartisiMilOy, toplamMilOy
                 , aPartisiMilyuzde, bPartisiMilyuzde, cPartisiMilyuzde, dPartisiMilyuzde, ePartisiMilyuzde
                 , aPartisiMilVek, bPartisiMilVek, cPartisiMilVek, dPartisiMilVek, ePartisiMilVek, partitoplamMilVek
                 , aPartisiyuzde, bPartisiyuzde, cPartisiyuzde, dPartisiyuzde, ePartisiyuzde, milletVekiliYuzde, milletVekiliGereken
                 , milletVekili;
            milletVekili = 600;
            milletVekiliGereken = 400;
            milletVekiliYuzde = milletVekili / 100;
            aPartisiOy = Convert.ToDouble(textBox1.Text);
            bPartisiOy = Convert.ToDouble(textBox2.Text);
            cPartisiOy = Convert.ToDouble(textBox3.Text);
            dPartisiOy = Convert.ToDouble(textBox4.Text);
            ePartisiOy = Convert.ToDouble(textBox5.Text);

            if (aPartisiOy >= milletVekiliGereken) { aPartisiMilOy = aPartisiOy; } else aPartisiMilOy = 0;
            if (bPartisiOy >= milletVekiliGereken) { bPartisiMilOy = bPartisiOy; } else bPartisiMilOy = 0;
            if (cPartisiOy >= milletVekiliGereken) { cPartisiMilOy = cPartisiOy; } else cPartisiMilOy = 0;
            if (dPartisiOy >= milletVekiliGereken) { dPartisiMilOy = dPartisiOy; } else dPartisiMilOy = 0;
            if (ePartisiOy >= milletVekiliGereken) { ePartisiMilOy = ePartisiOy; } else ePartisiMilOy = 0;

            partitoplamMilVek = aPartisiMilOy + bPartisiMilOy + cPartisiMilOy + dPartisiMilOy + ePartisiMilOy;

            aPartisiMilyuzde = (aPartisiMilOy / partitoplamMilVek) * 100;
            bPartisiMilyuzde = (bPartisiMilOy / partitoplamMilVek) * 100;
            cPartisiMilyuzde = (cPartisiMilOy / partitoplamMilVek) * 100;
            dPartisiMilyuzde = (dPartisiMilOy / partitoplamMilVek) * 100;
            ePartisiMilyuzde = (ePartisiMilOy / partitoplamMilVek) * 100;

            if (aPartisiOy >= milletVekiliGereken) aPartisiMilVek = aPartisiMilyuzde * milletVekiliYuzde; else aPartisiMilVek = 0;
            if (bPartisiOy >= milletVekiliGereken) bPartisiMilVek = bPartisiMilyuzde * milletVekiliYuzde; else bPartisiMilVek = 0;
            if (cPartisiOy >= milletVekiliGereken) cPartisiMilVek = cPartisiMilyuzde * milletVekiliYuzde; else cPartisiMilVek = 0;
            if (dPartisiOy >= milletVekiliGereken) dPartisiMilVek = dPartisiMilyuzde * milletVekiliYuzde; else dPartisiMilVek = 0;
            if (ePartisiOy >= milletVekiliGereken) ePartisiMilVek = ePartisiMilyuzde * milletVekiliYuzde; else ePartisiMilVek = 0;


           
            toplamOy = aPartisiOy + bPartisiOy + cPartisiOy + dPartisiOy + ePartisiOy;
            aPartisiyuzde = (aPartisiOy / toplamOy) * 100; bPartisiyuzde = (bPartisiOy / toplamOy) * 100; cPartisiyuzde = (cPartisiOy / toplamOy) * 100; dPartisiyuzde = (dPartisiOy / toplamOy) * 100; ePartisiMilyuzde = (ePartisiOy / toplamOy) * 100;
            
            aPartisiMilyuzde = (aPartisiMilOy / partitoplamMilVek) * 100; bPartisiMilyuzde = (bPartisiMilOy / partitoplamMilVek) * 100; cPartisiMilyuzde = (cPartisiMilOy / partitoplamMilVek) * 100; dPartisiMilyuzde = (dPartisiMilOy / partitoplamMilVek) * 100; ePartisiyuzde = (ePartisiOy / partitoplamMilVek) * 100;
            milletVekiliYuzde = partitoplamMilVek / 100;

      


            label10.Text = aPartisiyuzde.ToString("n2"); panel1.Width = Convert.ToInt32(aPartisiyuzde * 5); if (aPartisiOy >= milletVekiliGereken) panel1.BackColor = Color.LightGreen; else panel1.BackColor = Color.Red; 
            label11.Text = bPartisiyuzde.ToString("n2"); panel2.Width = Convert.ToInt32(bPartisiyuzde * 5); if (bPartisiOy >= milletVekiliGereken) panel2.BackColor = Color.LightGreen; else panel2.BackColor = Color.Red;
            label12.Text = cPartisiyuzde.ToString("n2"); panel3.Width = Convert.ToInt32(cPartisiyuzde * 5); if (cPartisiOy >= milletVekiliGereken) panel3.BackColor = Color.LightGreen; else panel3.BackColor = Color.Red;
            label13.Text = dPartisiyuzde.ToString("n2"); panel4.Width = Convert.ToInt32(dPartisiyuzde * 5); if (dPartisiOy >= milletVekiliGereken) panel4.BackColor = Color.LightGreen; else panel4.BackColor = Color.Red;
            label14.Text = ePartisiyuzde.ToString("n2"); panel5.Width = Convert.ToInt32(ePartisiyuzde * 5); if (ePartisiOy >= milletVekiliGereken) panel5.BackColor = Color.LightGreen; else panel5.BackColor = Color.Red;

            label15.Text = aPartisiMilVek.ToString("n0");
            label16.Text = bPartisiMilVek.ToString("n0");
            label17.Text = cPartisiMilVek.ToString("n0");
            label18.Text = dPartisiMilVek.ToString("n0");
            label19.Text = ePartisiMilVek.ToString("n0");




        }

      
    }
    
}
