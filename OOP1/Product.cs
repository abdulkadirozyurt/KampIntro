using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product  // Bu tip class larda sadece özellik olur. (Entity ---> Varlık)
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } // kod okunurluğu için alta yazmak yerine buraya yazdık.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } // ürünün birim fiyatı
        public int UnitsInStock { get; set; } // ürünün stok adedi

    }


}
