using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // 2 numara bizim için mobilya kategorisini temsil etsin.
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            //Farklı bir yazım şekli olarak:

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitsInStock = 5,
                UnitPrice = 35

            };

            // case sensitive
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager(); // "ProductManager" türündeki "productManager" yeni bir referans numarası almış "ProductManager"dır şeklinde okunur. (Heap'te adres sahibi olur yani.)

            productManager.Add(product1);
            productManager.Update(product2);
            productManager.Delete(product1);




            

        }

       
        // int double bool ---> değer tip
        // dizi class abstract class interface ---> referans tip

        // kamp 4. gün videosunda adres vs anlatılıyor.
    }
}


