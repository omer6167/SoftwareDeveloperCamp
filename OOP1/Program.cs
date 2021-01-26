using System;

namespace OOP1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product1 = new Product(); //101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //PascalCase   //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            int numb = 100;
            productManager.DoThings(numb);
            Console.WriteLine(numb); //100 

            productManager.Add2(product2);
            Console.WriteLine(product2.ProductName); //NewName

            //int,double,bool... value type
            //diziler,class, abstract class, interface ... reference type
            //ref out
        }
    }
}
