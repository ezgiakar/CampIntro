using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryHomework<int, int> cars = new DictionaryHomework<int, int>();
            cars.Add(34, 65000);
            cars.Add(35, 85000);
            cars.Add(41, 55000);

            cars.GetAll();
        }
    }
}
