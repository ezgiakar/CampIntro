using System;

namespace ClassMethodDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Büşra";
            customer1.CustomerSurname = "Lalala";
            customer1.CustomerEmail = "blabla@gmail.com";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Beyza";
            customer2.CustomerSurname = "Lalala";
            customer2.CustomerEmail = "blabla@gmail.com";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Ceren";
            customer3.CustomerSurname = "Lalala";
            customer3.CustomerEmail = "blabla@gmail.com";

            Customer customer4 = new Customer();
            customer4.CustomerId = 4;
            customer4.CustomerName = "Cansın";
            customer4.CustomerSurname = "Lalala";
            customer4.CustomerEmail = "blabla@gmail.com";

            Customer[] customers = { customer1, customer2, customer3, customer4 };

            CustomerManager.Add(customers[0]);
            CustomerManager.Add(customers[1]);
            CustomerManager.Add(customers[2]);
            CustomerManager.Add(customers[3]);

            CustomerManager.Delete(customers[0]);
            CustomerManager.Delete(customers[1]);
            CustomerManager.Delete(customers[2]);
            CustomerManager.Delete(customers[3]);

            CustomerManager.List(customers);

            Console.ReadLine();
        }
    }
}
