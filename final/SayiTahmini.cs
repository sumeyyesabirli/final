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
    public partial class SayiTahmini : Form
    {
        Random random;
        int sayi;
        int kalanTahmin;
        public SayiTahmini()
        {
            InitializeComponent();
        }

        private void SayiTahmini_Load(object sender, EventArgs e)
        {
            oyunuBaslat();
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            oyunuBaslat();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            try
            {
                int tahminEdilenSayi = Convert.ToInt32(txtSayiGirisi.Text);
                txtSayiGirisi.Clear(); // txtSayiGiris.Text = "";
                if (tahminEdilenSayi > sayi)
                {
                    MessageBox.Show(tahminEdilenSayi.ToString() + " sayısından daha küçük bir sayı tahmin edin");
                }
                else if (tahminEdilenSayi < sayi)
                {
                    MessageBox.Show(tahminEdilenSayi.ToString() + " sayısından daha büyüktür bir sayı tahmin edin");
                }
                else if (sayi == tahminEdilenSayi)
                {
                    MessageBox.Show("Tahmin Doğru kazandınız!!");
                    oyunuBitir();
                }
                if (kalanTahmin <= 1)
                {
                    MessageBox.Show("Tahmin sayınız bitmiştir oyuna tekrardan başlayabilirsiniz!");
                    oyunuBitir();
                }
                else
                {
                    kalanTahmin--; // kalanTahmin = kalanTahmin - 1;
                    lblKalanTamin.Text = "Kalan Tahmin : " + kalanTahmin.ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen sadece sayı giriniz!!");
            }
            
        }

        void oyunuBaslat()
        {
            random = new Random();
            kalanTahmin = 3;
            lblKalanTamin.Text ="Kalan Tahmin : " + kalanTahmin.ToString();
            sayi = random.Next(1, 100);
            btnOyunaBasla.Visible = false;
            btnTahmin.Visible = true;
        }

        void oyunuBitir()
        {
            lblKalanTamin.Text = "Sayı " + sayi.ToString() + " idi.";
            btnOyunaBasla.Visible = true;
            btnTahmin.Visible     = false;
        }

        private void txtSayiGirisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
