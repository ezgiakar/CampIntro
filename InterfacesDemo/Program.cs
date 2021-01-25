using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[] { new Worker(), new Manager()};
            // SOLID 
            //Single responsibility principle: Bir sınıfın yapması gereken yalnızca BİR işi olması gerekir.
            //Open/closed principle: Bir sınıf davranışını değiştirmemeli ve yeni özellikle kazanabiliyor olmalıdır.
            //Liskov substitution principle: Kodlarda bir değişiklik yapmadan alt sınıfları üst sınıfların yerine kullanabilmeliyiz.
            //Interface segregation principle: Sorumlulukları tek bir arayüze toplamak yerine birden fazla arayüz oluşturmalıyız.
            //Dependency inversion principle: Sınıflar arası bağımlılık az olmalı, özellikle üst seviye sınıflar alt seviyelere bağımlı olmamalı.
            Console.WriteLine("Hello World!");
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
