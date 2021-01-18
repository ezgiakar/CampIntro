using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
   public class Manager
    {

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productId = 1;
            product1.brand = "BMW";
            product1.productName = "Sedan";
            product1.unitPrice = 500000;

            Product product2 = new Product();
            product2.productId = 2;
            product2.brand = "Wolksvagen";
            product2.productName = "Passat";
            product2.unitPrice = 200000;

            Product[] products = new Product[] {product1, product2 };

            Console.WriteLine("foreach");
            foreach (var product in products)
            {
                Console.WriteLine("Ürün kodu: " + product.productId);
                Console.WriteLine("Ürün Markası: " + product.brand);
                Console.WriteLine("Ürün Adı: " + product.productName);
                Console.WriteLine("Ürün Fiyatı: " + product.unitPrice);
                Console.WriteLine("**************");
            }

            Console.WriteLine("for");


            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün kodu: " + products[i].productId);
                Console.WriteLine("Ürün Markası: " + products[i].brand);
                Console.WriteLine("Ürün Adı: " + products[i].productName);
                Console.WriteLine("Ürün Fiyatı: " + products[i].unitPrice);
                Console.WriteLine("+++++++++++++++++++++");
            }
            Console.WriteLine("while");
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine("Ürün kodu: " + products[j].productId);
                Console.WriteLine("Ürün Markası: " + products[j].brand);
                Console.WriteLine("Ürün Adı: " + products[j].productName);
                Console.WriteLine("Ürün Fiyatı: " + products[j].unitPrice);

                j++;
                Console.WriteLine("-------------------------");
            }
        }
    }
}
