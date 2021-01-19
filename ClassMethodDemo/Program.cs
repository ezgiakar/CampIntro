using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 100;
            customer1.CustomerName = "Beyza";
            customer1.CustomerSurname = "Blabla";

            Customer customer2 = new Customer();
            customer2.CustomerId = 101;
            customer2.CustomerName = "Ceren";
            customer2.CustomerSurname = "Blabla";

            Customer customer3 = new Customer();
            customer3.CustomerId = 103;
            customer3.CustomerName = "Büşra";
            customer3.CustomerSurname = "Blabla";

            Customer[] customers = new Customer[] {customer1, customer2, customer3 };

            CustomerManager.Add(customers[0]);
            CustomerManager.Add(customers[1]);
            CustomerManager.Add(customers[2]);

            CustomerManager.Delete(customers[0]);
            CustomerManager.Delete(customers[1]);
            CustomerManager.Delete(customers[2]);

            CustomerManager.List(customers);

            Console.ReadLine();

        }
    }
}
