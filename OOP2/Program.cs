using System;

namespace OOP2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IndividualCustomer individualCustomer = new IndividualCustomer
            {
                Id = 1,
                CustomerNo = "12345",
                FirstName = "Ömer",
                LastName = "Küçük",
                IdentityNo = "12345678910"
            };



            CorporateCustomer corporateCustomer = new CorporateCustomer
            {
                Id = 2,
                CustomerNo = "54321",
                CompanyName = "Kodlama.io",
                TaxNo = "1234567890"
            };

            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(individualCustomer);
            musteriManager.Add(corporateCustomer);

            Console.ReadLine();
        }
    }
}
