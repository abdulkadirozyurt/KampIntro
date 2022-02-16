using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager // bu şekilde bir isimlendirme görürsek, ürünle ilgili operasyonlar olduğunu anlayacağız. (ekleme, silme,güncelleme...)
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName+" silindi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }



        /*
         
         void anahtar kelimesi: 

            metoda (git; yap , et , ekle , sil, güncelle ...) şeklinde
            emir kipinde bir şeyler söyleriz ve metod gider onu yapar ve işlemi bitirir.
            
            işlemin sonucunda ne olduğu bilgisine ihtiyacımız yoktur. Bu durumlarda kullanırız.
         
         
         
         
         */



        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

    }
}
