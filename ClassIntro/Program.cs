using System;

namespace Program

{
    class Program
    {
        static void Main(string[] args)
        {


            // class bu şekilde yazılıyor kullanılıyor.

            KursBilgileri kurs1 = new KursBilgileri();    // KursBilgileri isimli bir tipimiz var artık. Bu tipte kurs1 adında bir değişken tanımladık. Sonra bu kurs1 değişkenine KursBilgileri adında yeni bir nesne atadık. 

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;



            KursBilgileri kurs2 = new KursBilgileri();

            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 37;


            KursBilgileri kurs3 = new KursBilgileri();

            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Kerem Varış";
            kurs3.IzlenmeOrani = 64;



            KursBilgileri kurs4 = new KursBilgileri();

            kurs4.KursAdi = "Python";
            kurs4.Egitmen = "Abdulkadir Özyurt";
            kurs4.IzlenmeOrani = 57;


            KursBilgileri kurs5 = new KursBilgileri();

            kurs5.KursAdi = "HTML";
            kurs5.Egitmen = "Emirhan Cıbır";
            kurs5.IzlenmeOrani = 97;


            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen+" "+kurs1.IzlenmeOrani);


            KursBilgileri[] kurslar = new KursBilgileri[] { kurs1, kurs2, kurs3, kurs4, kurs5 };  // KursBilgileri Array'inin içinde KursBilgileri class'ı tipinde veriler olacak demek. (***  İçinde KursBilgileri (array)  nesnesini barındıran, KursBilgileri class'ında bir array tanımladık ***)



            foreach (var kursBilgisi in kurslar) // kursBilgisi gibi bir takma isim (alias) tanımladık. *** foreach*** dizileri tekrar tekrar dönmeye yarar.
            {
                Console.WriteLine(kursBilgisi.KursAdi + " " + kursBilgisi.Egitmen + " " + kursBilgisi.IzlenmeOrani);
            }



        }
    }



    class KursBilgileri
    {
        // KursBilgileri isminde bir değişken tanımladık gibi. Sanki sen kendi veri tipini (int, string, double ...) yazıyormuşsun gibi düşün.

        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

        // üçünü beraber tutan bir tip tanımladık
    }











}