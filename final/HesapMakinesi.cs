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
    public partial class HesapMakinesi : Form
    {
        string islemYapilacak;
        public HesapMakinesi()
        {
            InitializeComponent();
        }
        List<string> islemler = new List<string>();
        private void HesapMakinesi_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            islemYapilacak += "1";
            textBox1.Text = islemYapilacak;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            islemYapilacak += "2";
            textBox1.Text = islemYapilacak;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            islemYapilacak += "3";
            textBox1.Text = islemYapilacak;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            islemYapilacak += "0";
            textBox1.Text = islemYapilacak;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            islemYapilacak += "6";
            textBox1.Text = islemYapilacak;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            islemYapilacak += "5";
            textBox1.Text = islemYapilacak;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            islemYapilacak += "4";
            textBox1.Text = islemYapilacak;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            islemYapilacak += "9";
            textBox1.Text = islemYapilacak;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            islemYapilacak += "8";
            textBox1.Text = islemYapilacak;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            islemYapilacak += "7";
            textBox1.Text = islemYapilacak;
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            islemler.Add("/");
            islemYapilacak += "/";
            textBox1.Text = islemYapilacak;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            islemler.Add("*");

            islemYapilacak += "*";
            textBox1.Text = islemYapilacak;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            islemler.Add("-");

            islemYapilacak += "-";
            textBox1.Text = islemYapilacak;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islemler.Add("+");
            islemYapilacak += "+";
            textBox1.Text = islemYapilacak;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            islemYap();
        }

        void islemYap()
        {
            double sonuc = 0;
            var splits = islemYapilacak.Split(new char[] { '+', '-', '*', '/' });
            string islem = "";
            for (int i = 0; i < islemler.Count; i++)
            {
                if (i == 0)
                    sonuc = Convert.ToDouble(splits[i]);
                if (islemler[i] == "+")
                {
                    sonuc += Convert.ToDouble(splits[i + 1]);
                }
                if (islemler[i] == "-")
                {
                    sonuc -= Convert.ToDouble(splits[i + 1]);
                }
                if (islemler[i] == "*")
                {
                    sonuc *= Convert.ToDouble(splits[i + 1]);
                }
                if (islemler[i] == "/")
                {
                    sonuc /= Convert.ToDouble(splits[i + 1]);
                }
            }
            listBox1.Items.Add(islemYapilacak + " = " + sonuc.ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            islemYapilacak = "";
            islemler = new List<string>();
            textBox1.Text = islemYapilacak;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            islemYapilacak = islemYapilacak.Substring(0, islemYapilacak.Length - 1);
            textBox1.Text = islemYapilacak;
        }
    }
}
