using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individual = new IndividualCustomer();
            individual.Id = 1;
            individual.CustomerNumber = "12345";
            individual.FirstName = "Tahir";
            individual.LastName = "Altundağ";
            individual.NationalityId = "12345678901";

            CorporateCustomer corporate = new CorporateCustomer();
            corporate.Id = 2;
            corporate.CustomerNumber = "54321";
            corporate.CompanyName = "Kodlama.io";
            corporate.TaxNumber = "123456789";


            Customer customer1 = new IndividualCustomer();

            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individual);
            customerManager.Add(corporate);
            customerManager.Add(customer2);
            customerManager.Add(customer1);
        }
    }
}
