using System;
using System.Collections.Generic;

namespace Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string Name = "Elma";
            double Price = 15;
            string Details = "Amasya elması";

            string[] fruits = { "Elma", "Karpuz" };

            Product product1 = new Product
            {
                Name = "Elma",
                Price = 15,
                Details = "Amasya elması"
            };

            Product product2 = new Product
            {
                Name = "Karpuz",
                Price = 80,
                Details = "Diyarbakır karpuzu"
            };

            Product[] products = { product1, product2 };


            List<Product> productsList = new List<Product>() { product1, product2 };


            //type-safe -- tip güvenli
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Details);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("------------Metotlar---------------");
            //instance - örnek
            //encapsulation

            ProductManager productsManager = new ProductManager();
            productsManager.Add(product1);
            productsManager.Add(product2);
            /*************/
            productsManager.Add2("Armut", "Yeşil armut", 12, 10);
            productsManager.Add2("Elma", "Yeşil elma", 12, 9);
            productsManager.Add2("Karpuz", "Diyarbakır karpuzu", 12, 8);
            /*************/
            Console.WriteLine("------------AddClassArray---------------");
            productsManager.AddClassArray(products);
            /*************/
            Console.WriteLine("------------AddClassLisst---------------");
            productsManager.AddClassList(productsList);

            Console.ReadLine();
        }
    }
}
