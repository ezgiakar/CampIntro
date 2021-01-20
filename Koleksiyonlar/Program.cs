using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Ezgi", "Büşra", "Ceren", "Beyza" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            // dizileri genişletemiyoruz.
            // diziler gerçek hayatta bir veri kaynağından geldiği için gidip değiştiremiyoruz arrayi.
            // bu nedenle genellikle array değil collection koleksiyon kullanılır.

            List<string> isimler2 = new List<string> { "Ezgi", "Büşra", "Ceren", "Beyza" };
            isimler2.Add("Gamze");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Sedef");

            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            // koleksiyonlarda diziler gibi değildir.
            // list içinde yer vardır.

            

        }
    }
}
