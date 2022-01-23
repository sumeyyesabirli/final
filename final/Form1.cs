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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSayiTahimi_Click(object sender, EventArgs e)
        {
            SayiTahmini sy = new SayiTahmini();
            sy.ShowDialog();
        }

        private void btnKronometre_Click(object sender, EventArgs e)
        {
            Kronometre kr = new Kronometre();
            kr.ShowDialog();
        }

        private void btnNesneleriHareketEttir_Click(object sender, EventArgs e)
        {
            NesneleriHareketEttirme nhe = new NesneleriHareketEttirme();
            nhe.ShowDialog();
        }

        private void btnKoselereCarpma_Click(object sender, EventArgs e)
        {
            KoselereCarpma kc = new KoselereCarpma();
            kc.ShowDialog();
        }

        private void btnSepetleMeyveYakala_Click(object sender, EventArgs e)
        {
            SepetleMeyveYakalama smy = new SepetleMeyveYakalama();
            smy.ShowDialog();
        }

        private void btnHesapMakinesi_Click(object sender, EventArgs e)
        {
            HesapMakinesi hm = new HesapMakinesi();
            hm.ShowDialog();
        }
    }
}

