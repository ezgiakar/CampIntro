using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety
            // do not repeat yourself
            //değer tutucu, alias takma isim
            string categoryEtiketi = "Category";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.56;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            // şart geçerliyse şu blok çalışsın demektir.
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(categoryEtiketi);
        }
    }
}
