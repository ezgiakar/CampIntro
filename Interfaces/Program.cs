using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /// InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), 
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()};
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }

        private static void Demo()
        {
            IPerson person = new Customer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer { FirstName = "Berat", Id = 1, LastName = "Akar", Address = "Kocaeli" };
            PersonManager manager = new PersonManager();
            Student student = new Student { Id = 2, FirstName = "Ezgi", LastName = "Akar", Department = "Economics" };

            manager.Add(student);
            manager.Add(customer);
        }
    }

    interface IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person) 
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
