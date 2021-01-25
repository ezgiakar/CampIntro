using System;

namespace Interfaces2
{
    class Program
    {
        //interfaces newlenemez.
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

        }
    }

    class PersonManager
    {
        // imlemented operation, addden bahsediyor, içi dolu.
        // interfacelerde içi doldurulmaz.
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
    }
    //dışarıdan erişilebilir olmalıdır.
    //implemente edilen sınıfın kendisi içini doldurur.
    //her yerde ortak olsaydı üstteki gibi manager içinde methodla yazardık.
    // interfacelerde imza aynı ama personel ve yöneticilerde farklıdır.
    interface IPersonManager
    {
         void Add();
         void Update();
    }

    // inherits - class --- interface - implements

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri kodları
            Console.WriteLine("Müşteri ekleme kodları.");
        }

        public void Update()
        {

            Console.WriteLine("Müşteri update kodları.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel ekleme kodları");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri update kodları.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern  eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Intern güncellendi");
        }
    }

    class ProjectManager 
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
