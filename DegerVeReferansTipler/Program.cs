using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1= 30 doğruuu

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 10 yanlışş 999
            //int, decimal. bool, float, double = değer tip
            //array, class, interface = referans tip
            //stack alanı değer tip olanlar burada gerçekleşir. Burada hangi değeri atarsan o kalır.
            //sonrasında değiştirsen de değişmez.
            // heap alanı referans tip olanlar burada gerçekleşir. new dediğim an heapde alan oluşur.
            //sayılar1in sayılar2nin referans nmarasına eşittir anlamına gelmektedir eşitleme.
            //sayılar1i bellekten atıyor sayılar2ye eşitlenince
        }
    }
}
