using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{                                           // I interface'lerin başına eklenir.
    interface ICreditManager      // bir interface der ki. Birisi bu interface'i kullanırsa eğer, o arkadaş şu metodu içermek zorunda.
    {
        void Calculate();
        void BirSeyYap();
    }
}







// genellikle operasyonel metotlarda interface'ler kullanılır.