using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();

            Console.ReadLine();
        }
    }

    abstract class MevzuatBase
    {
        public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi."); 
        }
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevzuatına göre değerlendirildi.");
        }
    }

    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B Mevzuatına göre değerlendirildi.");
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
}
