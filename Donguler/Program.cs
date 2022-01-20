using System;

namespace Program  
{
    class Program
    {
        static void Main(string[] args)
        {

            //string kurs1 = "Yazılım Geliştirici Kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java Kursu";

            // array - dizi

            string[] kurslar = new string[] {"C#","c++","python kursu", "Yazılım Geliştirici Kampı", "Programlamaya başlangıç için temel kurs","Java Kursu" };


            for (int i = 0; i <kurslar.Length; i++) // lenght = eleman sayısı. Burada eleman sayısı 4 tür. (0. 1. 2. 3.)     dinamik olması için kurslar dizisinin son elemanına kadar alabilmesi için bu şekilde yaptık
            {

                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n");

            Console.WriteLine("for bitti");

            Console.WriteLine("\n\n\n");
            // farklı bir döngü yöntemi. Yazım şekli.






            // foreach dizilere uygulanır
            foreach (string kurs in kurslar) // dizi temelli yapıları tek tek dönmeye yarar
            {

                Console.WriteLine(kurs);


            }

   



            Console.WriteLine("\nSayfa Sonu");
        }
    }
}