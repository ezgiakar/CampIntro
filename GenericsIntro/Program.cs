using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            // string verdik ama int de verebilirim, class da.
            // array yerine bunu kullanırız.
            isimler.Add("Ezgi");

            Console.WriteLine("Hello World!");
        }
    }
}
