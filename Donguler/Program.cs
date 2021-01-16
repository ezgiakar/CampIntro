using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // array = dizi tek tek tanımlamak yerine bir arrayde tutuyoruz.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java",
                "Python"
                , "C++"};

            // 1den başla, 10dam küçük olduğu sürece çalış, 1 arttır. ortadaki şarttır.
            // iy, 0dan başlat 3den küçük olduğu sürece iyi 1 arttır.
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            //for ile farkı dizi temelli yapıları tek tek dönmeye yarar. Kursları tek tek dolaş
            // foreach dizilere uygulanır.
            //foreachde forda kurslar için i yazardık ama bunda gerek yok.
            //kurs yerine her şey yazılabilir.
            //ikisi de kullanılabilir.
            //gitap hesabıı.

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
