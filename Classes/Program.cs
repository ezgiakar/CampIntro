using System;
namespace Classes

{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductrManager productrManager = new ProductrManager();
            productrManager.Add();
            productrManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ezgi";
            customer.LastName = "Akar";
            customer.City = "Kocaeli";

            Console.WriteLine(customer.FirstName);

            Console.ReadLine();

        }
    }

}
