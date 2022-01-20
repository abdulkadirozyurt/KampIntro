using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {



            // bir class tanımlamak için bunu yazmamız gerekir. Bu kısma class'ın örneği denir. 

            // Class'ın örneği : 





            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


             //şimdi; nasıl string tipinde bir array oluşturabiliyorsak, Urun tipinde de bir array oluşturalım.

            Urun[] urunler = new Urun[] { urun1, urun2, };    // Urun tipinde bir array oluşturduk, urunler diye bir değişken tanımladık.

            foreach (Urun /* Urun: Veri tipi (c#, java gibi diller tip güvenlidir. (type safe) Yani çalışacağım veri tipini bana söyle bileceğim demek ister dil.) */ urun /* urun: alias takma isim */ in urunler) //urunler dizisinin her bir elemanını tek tek gez demek.

            { 
                // bu foreach yapısı ürün sayısı kadar tek tek dönmeye yarar. Önce biri için sonuna kadar döner sonra diğeri sonra diğeri.



                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");


            }




            Console.WriteLine("----------Metotlar---------");




            // instance- örnek oluşturma

            //encapsulation 

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("-------------------");


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,25);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,50);




        }
    }
}








// Metotlar bizim için, tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır. 

// Do not repeat yourself. - DRY- Clean Code- Best Practice