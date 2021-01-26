using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    internal class ProductManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine($"Successful. Added to cart : {product.Name}");
        }

        public void Add2(string productName, string productDetails, double price, int unitInStock)
        {
            Console.WriteLine($"Successful. Added to cart : {productName}");
        }

        public void AddClassArray(Product[] product)
        {
            foreach (var item in product)
            {
                Console.WriteLine($"Successful. Added to cart : {item.Name}");
            }
        }

        public void AddClassList(List<Product> productsList)
        {
            foreach (var item in productsList)
            {
                Console.WriteLine($"Successful. Added to cart : {item.Name}");

            }
        }
    }
}
