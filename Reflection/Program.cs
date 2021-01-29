using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //diyelim ki çalışma anında yapmak istiyoruz. o zaman reflection kullanırız.
            //Math math = new Math(2,3); aşağıdaki activator ile aynıdır. Gelen tipe göre örnek yapmış oluruz.
            //Console.WriteLine( math.Sum1() );
            //Console.WriteLine( math.Sum(3,4) ); 

            var type = typeof(Math);

            Math math = (Math)Activator.CreateInstance(type, 6, 7);
            math.Sum(4, 5);

            Console.ReadLine();
        }
    }

    public class Math
    {
        int _sayi1;
        int _sayi2;

        public Math(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        
        public int Sum(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Sum1()
        {
            return _sayi1 + _sayi2;
        }

        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }
}
