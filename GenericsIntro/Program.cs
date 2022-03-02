using System;

namespace GenericsIntro
{
    class Program      // şu an List gibi bir şeyi nasıl yazardık bunu öğreniyoruz.
    {
        static void Main(string[] args)
        {

            // MyList isimler = new MyList(); // ben generic bi class'ım diyor bu yüzden bize kızıyor.


            MyList<string> isimler = new MyList<string>();
            isimler.Add("Abdulkadir");
        }
    }
}
