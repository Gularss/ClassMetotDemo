using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Gülden";
            customer.Surname = "Sönmez";
            customer.Address = "Bahçelievler";

            Customer customer1 = new Customer();
            customer1.Id = 2;
            customer1.Name = "İsmail";
            customer1.Surname = "Sönmez";
            customer1.Address = "Bahçelievler";

            Customer customer2 = new Customer { Id = 3, Name = "Batuhan", Surname = "Sönmez", Address = "Bahçeliever" };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.WriteLine("------------------------------------");

            customerManager.Delete(customer);
        }
    }
}
