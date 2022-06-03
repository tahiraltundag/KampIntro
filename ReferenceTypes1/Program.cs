using System;

namespace ReferenceTypes1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Tahir";
            person2 = person1;
            person1.FirstName = "Derin";


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = 123456;

            Employee employee = new Employee();

            Person person3 = customer;
            customer.FirstName = "Ahmet";


            Console.WriteLine(((Customer)person3).CreditCardNumber);

            Console.WriteLine(person3.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add2(employee);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public int CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Customer customer)
        {
            //Bu şekilde yaparsanız sadece müşteriyle çalışmış olursunuz.
        }

        public void Add1(Employee employee)
        {
            //Bu şekilde yaparsanız sadece çalışanla çalışmış olursunuz.
        }

        public void Add2(Person person)
        {
            //Bu şekilde yaparsanız isa hem kişiyi hem müşteriyi hemde çalışanı gönderebilirsiniz
            //Çünkü yukarıda person3 ü customer a eşitledik, aynı zamanda employe yi de eşitleyebiliriz
            Console.WriteLine(person.FirstName);
        }
    }
}
