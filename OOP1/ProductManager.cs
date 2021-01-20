using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}

        // void nedir? 
        // void ile intle yazmak arasındaki fark nedir?
        // topla2 işlemini yapıyor ve ekrana yazdırıyor.
        // peki neden returne ihtiyaç var?
        // işlem sonucunda ortaya çıkan sonucu kullanmak istiyorum.
        // void ile bunu yapmam mümkün değil.
        // bu nedenle int ile yazılanı kullanırız.
        // int toplamSonuc = productManager.Topla(3,6);
        // ve bu sonucun üzerinde çalışıyorum.
        // cw(toplamSonuc*2); gibi.
        // voidde newleme ya da değer verme olmaz.
        // ama int ya da string vs verdiğinde o değeri bu şekilde veriririz ve return ederiz.
    }
}
