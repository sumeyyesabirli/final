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
    public partial class SepetleMeyveYakalama : Form
    {

        int hiz1;
        int hiz2;
        int hiz3;
        int altHizSiniri = 10;
        int ustHizSiniri = 50;
        Random rnd;
        int yerYuksekligi = 550;
        int maksXDegeri = 600;
        int kalanCan = 3;
        int skor = 0;
        bool basladiMi = false;

        public SepetleMeyveYakalama()
        {
            InitializeComponent();
        }

        private void SepetleMeyveYakalama_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(basladiMi)
            {
                pictureBox1.Top += hiz1;
                pictureBox2.Top += hiz2;
                pictureBox3.Top += hiz3;
                yereCarpmayiKontrolEt();
                sepeteCarpmayiKontrolEt();
            }
        }

        void sepeteCarpmayiKontrolEt()
        {

            if (Math.Abs((pictureBox1.Location.X - pictureBox4.Location.X)) < 50 && Math.Abs((pictureBox1.Location.Y - pictureBox4.Location.Y)) < 50)
            {
                Random r1 = new Random();
                var x1 = r1.Next(0, maksXDegeri);
                hiz1 = rnd.Next(altHizSiniri, ustHizSiniri);
                pictureBox1.Location = new Point(x1, 0);
                skor++;
            }
            if (Math.Abs((pictureBox2.Location.X - pictureBox4.Location.X)) < 50 && Math.Abs((pictureBox2.Location.Y - pictureBox4.Location.Y)) < 50)
            {
                Random r2 = new Random();
                var x2 = r2.Next(0, maksXDegeri);
                hiz2 = rnd.Next(altHizSiniri, ustHizSiniri);
                pictureBox2.Location = new Point(x2, 0);
                skor++;
            }
            if (Math.Abs((pictureBox3.Location.X - pictureBox4.Location.X)) < 50 && Math.Abs((pictureBox3.Location.Y - pictureBox4.Location.Y)) < 50)
            {
                Random r3 = new Random();
                var x3 = r3.Next(0, maksXDegeri);
                hiz1 = rnd.Next(altHizSiniri, ustHizSiniri);
                pictureBox3.Location = new Point(x3, 0);
                skor++;
            }
            lblSkor.Text = "Skor : " + skor.ToString();

        }

        void yereCarpmayiKontrolEt()
        {
            if (pictureBox1.Top > yerYuksekligi)
            {
                Random r1 = new Random();
                var x1 = r1.Next(0, maksXDegeri);
                hiz1 = rnd.Next(altHizSiniri, ustHizSiniri);
                pictureBox1.Location = new Point(x1, 0);
                kalanCan--;
            }

            if (pictureBox2.Top > yerYuksekligi)
            {
                Random r2 = new Random();
                var x2 = r2.Next(0, maksXDegeri);
                hiz2 = rnd.Next(altHizSiniri, ustHizSiniri);
                pictureBox2.Location = new Point(x2, 0);
                kalanCan--;
            }

            if (pictureBox3.Top > yerYuksekligi)
            {
                Random r3 = new Random();
                var x3 = r3.Next(0, maksXDegeri);
                hiz1 = rnd.Next(altHizSiniri, ustHizSiniri);
                pictureBox3.Location = new Point(x3, 0);
                kalanCan--;
            }
            if(kalanCan <= 0)
            {
                bitir();
            }
            lblCan.Text = "Kalan Can: " + kalanCan; // $"Kalan Can : {kalanCan}";
        }

        private void basla()
        {
            basladiMi = true;
            timer1.Start();
            kalanCan = 10;
            rnd = new Random();
            hiz1 = rnd.Next(altHizSiniri, ustHizSiniri);
            hiz2 = rnd.Next(altHizSiniri, ustHizSiniri);
            hiz3 = rnd.Next(altHizSiniri, ustHizSiniri);
        }

        private void bitir()
        {
            basladiMi = false;
            yerleriSifirla();
            timer1.Stop();
            MessageBox.Show("Oyun Bitti! Sokrunuz : " + skor);
            skor = 0;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            basla();
        }

        void yerleriSifirla()
        {
            //objelerin X ve Y kordinatlarını ayarlar 
            pictureBox1.Location = new Point(100, 0);
            pictureBox2.Location = new Point(300, 0);
            pictureBox3.Location = new Point(500, 0);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.D)
            {
                pictureBox4.Left += 50;
            }
            else if (keyData == Keys.A)
            {
                pictureBox4.Left -= 50;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
