using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class ProductManager
    {
        //encapsulation
        public void Add(Product product)//101
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public void DoThings(int numb)
        {
            numb = 0;
        }

        public void Add2(Product product)
        {
            product.ProductName = "NewName";
        }
    }
}
