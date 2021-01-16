using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"Elma", "Karpuz" };
            //class olduğu için productı newleriz.

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1,product2 };

            //type-safe -- tip güvenli ne ile çalışacağını bilmek ister, product burada tip verir
            // var ürünü direkt product tipi yapar.
            foreach (Product product in products) // her elemanı tek tek gez ve ekrana yazdır.
            { 
               // normalde htmlde mesela <li> {}<li> gibi yazılır
                // cw programcı yazı aracıdır.  program içinde kullanılmaz normalde. dil yazanın ne çıkacağını görmesi işine yarar.
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("-------------------------");
            }



            // genellikle bu productlar bir veri kaynağından gelir.

            // classla da array oluşturabiliriz.

            Console.WriteLine("----------Methods------------");
            //instance- class örneği ulaştırmak.
            //encapsulation = kapsülleme demektir.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil armut", 12);

            Console.WriteLine("Hello World!");
        }
    }
}




// do not repeat yourself! dry clean code
