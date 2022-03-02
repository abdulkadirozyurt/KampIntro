using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{                                                           
    class MortgageLoanManager : ICreditManager  // diyor ki bir interface'i kullanıyorsan onun kurallarına uymak zorundası. (hata bu) onun içindeki metodu içermelisin.
    {
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı.");
        }
    }
}
