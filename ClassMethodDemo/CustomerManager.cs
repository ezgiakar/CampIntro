using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public static void Add(Customer customer)
        {
            Console.WriteLine("Customer added. " + " Id: " + customer.CustomerId + " Name: " + customer.CustomerName + " Surname: " + customer.CustomerSurname);
            Console.WriteLine("********");
        }

        public static void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted. " + " Id: " + customer.CustomerId + " Name: " + customer.CustomerName + " Surname: " + customer.CustomerSurname);
            Console.WriteLine("*********");
        }

        public static void List(Customer[] customer)
        {
            Console.WriteLine("List of customers.");
            foreach (var customers in customer)
            {
                Console.WriteLine("Listed: " + " Id: " + customers.CustomerId + " Name: " + customers.CustomerName + " Surname: " + customers.CustomerSurname);
                Console.WriteLine("**********");
            }
        }

    }
}
