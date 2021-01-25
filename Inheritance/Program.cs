 using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.FirstName = "Ezgi";

            Person[] people = new Person[] { new Customer {FirstName ="Ezgi" }, new Student {
            FirstName = "Büşra"}, new Person {FirstName="Berat" } };

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LasName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
