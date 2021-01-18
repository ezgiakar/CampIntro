using System;

namespace HomeWork1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
    }
    class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public double unitPrice { get; set; }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 1;
            product1.productName = "Gülün Adı";
            product1.unitPrice = 45;

            Product product2 = new Product();
            product2.productId = 2;
            product2.productName = "Tutunamayanlar";
            product2.unitPrice = 40;

            Product product3 = new Product();
            product3.productId = 3;
            product3.productName = "Üçüncü Dalga";
            product3.unitPrice = 35;

            Product[] Products = new Product[] { product1, product2, product3 };

            foreach (var product in Products)
            {
                Console.WriteLine(product.productId
                + ":" + product.productName + ":" + product.unitPrice);
            }



            Console.WriteLine("****************************");

            int i = 0;

            while (i < Products.Length)
            {
                Console.WriteLine(Products[i].productId);
                Console.WriteLine(Products[i].productName);
                Console.WriteLine(Products[i].unitPrice);

                i++;
            }

            for (int j = 0; j < Products.Length; j++)
            {
                Console.WriteLine("Ürün Kodu: " + Products[j].productId);
                Console.WriteLine("Ürün Adı: " + Products[j].productName);
                Console.WriteLine("Fiyatı : " + Products[j].unitPrice + " TL");
                Console.WriteLine("- - - - - - - - - - - - ");
            }
        }
    }
 }