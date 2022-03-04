using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplyManager
    {                       // elimde herkesin referansını tutabilen bir ICreditManager var. 
        
        // Method injection
        public void Apply(ICreditManager creditManager, ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendirme.

            creditManager.Calculate();
            
            loggerService.Log();                // hangi loglayıcı seçilmişse onu logla diyorum burada.

                                            // şu an tüm başvuru işlemlerini konut kredisine bağımlı hale getirdik.
        }

                                                    //kaç tane kredi görüntüleneceği belli değil. sıfır da olabilir 1000 de olabilir. o yüzden list ver bana.
                                                    // listenin türü ICreditManager
        public void CreditPreliminaryInformation(List<ICreditManager> credits) // kredi ön bilgilendirmesi
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
