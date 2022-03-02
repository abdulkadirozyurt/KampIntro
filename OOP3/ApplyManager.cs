using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplyManager
    {                       // elimde herkesin referansını tutabilen bir ICreditManager var. 
        public void Apply(ICreditManager creditManager)
        {
            // Başvuran bilgilerini değerlendirme.

            creditManager.Calculate();

            // şu an tüm başvuru işlemlerini konut kredisine bağımlı hale getirdik.
        }
    }
}
