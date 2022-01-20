using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Urun // diyorsun ki bir ürünün, ürün olabilmesi için çeşitli özellikleri barındırması gerekir.
    {




        // CLASS : string gibi int gibi bir bilgiyi değil de, bir nesneyi tanımlayan birden fazla bilgiyi içeren yapıdır.


        // Id: Bir datayı diğerlerinden ayırt etmek için kullandığımız eşsiz değerdir. TC gibi.


        //Propery-özellik. aşağıyı prop yazıp çift tab yaparak yazıyoruz.



        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }


    }
}
