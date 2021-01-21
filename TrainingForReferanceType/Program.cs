using System;

namespace TrainingForReferanceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Ezgi";

            Person person2 = new Person();
            person2.FirstName = "Beyza";

            person1 = person2;

            person2.FirstName = "Ceren";

            Customer customer = new Customer();
            customer.FirstName = "Mine";

            Person person3 = new Person();
            person3.FirstName = "Lale";
            person3 = customer;

            Employee employee = new Employee();
            employee.FirstName = "Nurtaç";

            person3 = employee;


            Console.WriteLine("Person3 : " + person3.FirstName);
            Console.WriteLine("Person3 : " + person3.FirstName);
            Console.WriteLine("Person1 = " + person1.FirstName);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer: Person
    {
        public int CreditCard { get; set; }
    }

    class Employee: Person //inheritance
    {
        public double Salary { get; set; }
    }
}
