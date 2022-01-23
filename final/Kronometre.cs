using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class Kronometre : Form
    {
        public Kronometre()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrKronometre.Start();
            listBox1.Items.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrKronometre.Stop();
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat   = 0;
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(suankiZaman);

        }
        int salise = 0;
        int saniye = 0;
        int dakika = 0;
        int saat   = 0;
        string suankiZaman;
        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            salise++;
            if(salise == 100)
            {
                saniye++;
                salise = 0;
            }
            if(saniye == 60)
            {
                dakika++;
                saniye = 0;
            }
            if(dakika == 60)
            {
                saat++;
                dakika = 0;
            }
            string lbSalise = salise < 10 ? "0" + salise.ToString() : salise.ToString();
            /*
             * Yukarıdaki kod ile aynı işlevi görüyor!
            if (salise < 10)
                lbSalise = "0" + salise.ToString();
            else
                lbSalise = salise.ToString();
            */
            string lbSaniye = saniye < 10 ? "0" + saniye.ToString() : saniye.ToString();
            string lbDakika = dakika < 10 ? "0" + dakika.ToString() : dakika.ToString();
            string lbSaat = saat < 10 ? "0" + saat.ToString() : saat.ToString();

            suankiZaman = lbSaat + " : " + lbDakika + " : " + lbSaniye + " : " + lbSalise;
            //lblKronometere.Text = $"{lbSaat} : {lbDakika} : {lbSaniye} : {lbSalise}"; //yukarıdaki ile aynı işlevi görüyor.
            lblKronometere.Text = suankiZaman;
        }

        private void Kronometre_Load(object sender, EventArgs e)
        {
            tmrKronometre.Interval = 1;
        }
    }
}
