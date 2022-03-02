using System;

namespace OOP2                              // soyutlama : abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "123456";
            customer1.FirstName = "Abdulkadir";
            customer1.LastName = "Özyurt";
            customer1.TcNo = "456879131";


            // Kodlama.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.TaxNumber = "123456467890";
            customer2.CompanyName = "Kodlama.io";

            // neden inheritance yapıyoruz????



            // Customer class'ı, onu inherit eden (IndividualCustomer ve CorporateCustomer) class'ların referansını tutabiliyor.


            Customer customer3 = new IndividualCustomer();    
            Customer customer4 = new CorporateCustomer();

            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
            


        }
    }
}
