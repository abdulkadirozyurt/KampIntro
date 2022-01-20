using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem
    {


        // Topla(2,3) şeklinde.

        public void Topla(int sayi1, int sayi2) // topla metodunu (fonksiyon da diyebiliriz) kullanaibilmen için senin ona iki sayı vermen lazım demek.

        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }


        public void Cıkar(int sayi1, int sayi2)
        {
            int Fark = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + Fark);
        }
    }
}
