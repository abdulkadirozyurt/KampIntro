using System;
using System.Collections.Generic;

namespace OOP3                          // interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ICreditManager consumerLoanManager = new ConsumerLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();


            // interface'ler de o interface'i implemente eden class'ın referansını tutabilirmiş.



            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //ILoggerService fileLoggerService = new FileLoggerService();


            ApplyManager applyManager = new ApplyManager();

                                                    // farklı bir instance oluşturma yöntemi     
            applyManager.Apply(vehicleLoanManager, new FileLoggerService()); // konut kredisine başvuru yap, loglamayı veritabanına yap.

            List<ICreditManager> credits = new List<ICreditManager>()
            {
                consumerLoanManager, vehicleLoanManager
            };


            //  applyManager.CreditPreliminaryInformation(credits);

        }
    }
}
