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
    public partial class KoselereCarpma : Form
    {
        public KoselereCarpma()
        {
            InitializeComponent();
        }
        bool xInterval = true;
        bool yInterval = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int hiz = 5;

            //burada butonun o anki lokasyonularını alıyoruz
            var x = button1.Location.X;
            var y = button1.Location.Y;

            //10 dk sigara molası :D 

            //600 bizim sınırlarımız
            //buton sınırı aştığı an, örn; X için xInterval değerini tersine çeviriyoruz böylece
            //aşağıda bulunan ++ veya -- işlemlerini xIntervale göre veriyoruz
            if (x > 600)
                xInterval = false;
            if (y > 600)
                yInterval = false;
            if (x < 0)
                xInterval = true;
            if (y < 0)
                yInterval = true;

            //Yıkarıda verdiğimiz xInterval true veya false göre arttırma veya azaltma işlemi yapıyoryz
            //x 600 veya 0 eşiğini aştığı an tam tersi şekilde ( 10'dan 0'a 10ar 10ar azaırken 10ar 10ar artmaya başlıyor) 
            // yeni değerleri setliyoruz
            if (xInterval)
                x = x + hiz; 
            else
                x = x - hiz; 

            if (yInterval)
                y = y + hiz; 
            else
                y = y - hiz; 

            //yeni değer setleme işlemi burada yapılıyor
            button1.Location = new Point(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void KoselereCarpma_Load(object sender, EventArgs e)
        {

        }
    }
}
