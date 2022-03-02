using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro    // şu an List gibi bir şeyi nasıl yazardık bunu öğreniyoruz.
{
    // generic class ---> çalışacağınız özel bir tip olduğunu belirtmek demek.


    class MyList<T> // olarak verebiliriz. Type tan gelir. Ben MyList imde T ile çalışacağım demek. 
    {

        T[] items;

        public MyList()     // class la aynı isim. constructor ---> ctor + tab tab --> class'ı bir yerde newlersek otomatik çalışır.
        {                   //newledik oluşturduk ve sıfır elemanlı olarak verdik.
            items = new T[0];
        }




        // item eleman demek. Genel olsun diye yazdık istenilen şey yazılabilir.

        

        public void Add(T item) // benim çalışacağım tip, programcı new'lerken ne verirse o olsun.
        {
            T[] tempArray = items; // items ın elemanları newleyince kaybolmasın diye geçici diziye tutturduk.
            items =new T[items.Length+1]; // newlediğimiz için adres uçar gider ilk elemanlar gider.

            for (int i = 0; i < tempArray.Length; i++) // emanet olarak temp e verdiğimiz verileri geri ver diyoruz.
            {
                items[i] = tempArray[i]; // items ın i. elemanı temparrayden gelen i. elemandır. verdiklerimi sırasıyla geri alıyorum
                 
            }

            items[items.Length-1] = item;   // aslında eklenmek istenen elemanı şu anda eklemiş olduk.
        
        }

    }
}
