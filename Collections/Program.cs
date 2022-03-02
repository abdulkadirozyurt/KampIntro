using System;
using System.Collections.Generic;


namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack          // Heap   //değerler
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" }; // bu, isimler array'i 4 tane elemandan oluşuyor demek.

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5];
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]); // yukarıda new'ledik ve bellekte yeni bir adres oluştu, tekrardan 0'ıncı elemanı yazdırmaya çalıştığımızda bunu yazmadı.

            // yani dizileri bu şekilde eleman sayısı bakımından genişletemiyoruz. Daha farklı çalışacağız bu konuda.

            // c# ve javada genellikle array yerine collection kullanılır.

            Console.WriteLine("------------------------------------");



            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            Console.WriteLine("----- 5.elemanı ekledik");

            isimler2.Add("İlker");            // şeklinde listeye yeni bir eleman ekleriz ve array'de olduğu gibi "dizi sınırı aşıldı" hatasını almadan devam edebiliriz.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //foreach (var isim in isimler2)
            //{
            //    Console.WriteLine(isim);     // dizilerde olduğu gibi foreach aynı şekilde kullanılabilir.
            //}



            
            
        }
    }
}
