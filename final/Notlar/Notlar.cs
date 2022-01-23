using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.Notlar
{
    public class Notlar
    {
        int a;
        //Fonksiyonlar değer döndüren ve değer döndüremyen olarak ikiye ayrılır...
        //Değer döndürmeyecekse başına void konur
        public void bisiDondurmeyenFonksiyon()
        {
            int x = 5;
            int y = 7;

          //  int toplam = x + y;

            int tp = toplam(4, 5);
        }

        public int toplam(int a, int b)
        {
            return a + b;
        }

    }
}
