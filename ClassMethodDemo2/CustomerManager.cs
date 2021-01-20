using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo2
{
    public class CustomerManager
    {
        public static void Add(Customer customer)
        {
            Console.WriteLine("Added!");
            Console.WriteLine(" Id: " + customer.CustomerId);
            Console.WriteLine( " Name: " + customer.CustomerName);
            Console.WriteLine(" Surname: " + customer.CustomerSurname);
            Console.WriteLine(" Email: " + customer.CustomerEmail);
        }

        public static void Delete(Customer customer)
        {
            Console.WriteLine("Deleted!");
            Console.WriteLine(" Id: " + customer.CustomerId);
            Console.WriteLine(" Name: " + customer.CustomerName);
            Console.WriteLine(" Surname: " + customer.CustomerSurname);
            Console.WriteLine(" Email: " + customer.CustomerEmail);
        }

        public static void List(Customer[] customers)
        {
            Console.WriteLine("List of customers");
            foreach (var customer in customers)
            {
                Console.WriteLine("Listed!");
                Console.WriteLine(" Id: " + customer.CustomerId);
                Console.WriteLine(" Name: " + customer.CustomerName);
                Console.WriteLine(" Surname: " + customer.CustomerSurname);
                Console.WriteLine(" Email: " + customer.CustomerEmail);
            }
        }
    }
}
