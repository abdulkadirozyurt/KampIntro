using System;

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


            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(consumerLoanManager);
            applyManager.Apply(vehicleLoanManager);
            applyManager.Apply(mortgageLoanManager);


        }
    }
}
