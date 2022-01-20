using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{


    // Manager, service vb. gibi şeyler içerisinde bir OPERASYON tutar.


    class SepetManager
    {
        // sepete ekle işlemi nasıl yapılır ona bakalım. Metot yazıyoruz.

        // naming convention- isimlendirme kuralı

        // parametre eklemeliyiz. Burada parametre : urun        Sadece ekle dersek olmaz. Ne ekleyeceğini söylememiz lazım.

        public void Ekle(Urun urun)      //bir yerde normal parantez varsa orada bir metot çalışıyor demektir.
        {
            
            Console.WriteLine("Tebrikler! Sepete eklendi : "+urun.Adi+" "+urun.Fiyati+" "+urun.Aciklama);


        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : "+urunAdi+" "+aciklama);
        }











    }
}
