﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = " Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId = 1, ProductName = " Acer Laptop",
                    QuantityPerUnit=32, UnitPrice =10000, UnitInStock = 5},
                new Product{ProductId=2,CategoryId = 1, ProductName = " Asus Laptop",
                    QuantityPerUnit=32, UnitPrice =8000, UnitInStock = 3},
                new Product{ProductId=3,CategoryId = 1, ProductName = " Hp Laptop",
                    QuantityPerUnit=32, UnitPrice =6000, UnitInStock = 2},
                new Product{ProductId=4,CategoryId = 2, ProductName = " Samsung",
                    QuantityPerUnit=32, UnitPrice =5000, UnitInStock = 15},
                new Product{ProductId=5,CategoryId = 2, ProductName = " Apple",
                    QuantityPerUnit=32, UnitPrice =8800, UnitInStock = 0}
            };

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            GetProducts(products);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filtredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filtredProducts.Add(product);
                }
            }

            return filtredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
           return  products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
        }


    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
