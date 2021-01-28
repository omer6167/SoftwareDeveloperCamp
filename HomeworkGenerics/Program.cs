using System;
using System.Runtime.CompilerServices;

namespace HomeworkGenerics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataList<Products> productDataList = new DataList<Products>();
            Console.WriteLine($"uzunluk : {productDataList.Length}");

            Products product1 = new Products { Id = 1, Name = "ömer", Details = "1.elaman", Price = 100, UnitInStock = 10 };
            Products product2 = new Products { Id = 2, Name = "küçük", Details = "2.elaman", Price = 10, UnitInStock = 20 };
            Products product3 = new Products { Id = 3, Name = "NewName", Details = "3.elaman", Price = 1, UnitInStock = 30 };

            productDataList.Add(product1, product2,product3);
            productDataList.Update(1, product1);

            foreach (var item in productDataList) // We can iterate because of GetEnumerator() method
            {
                Console.WriteLine(item.ToString()); // item's type is Product so we did override ToString() for see the properties
            }
            // Console.WriteLine(productDataList.LastValue.ToString()); //Last value's type is Product, we did override ToSting() method

            Console.WriteLine($"Length : {productDataList.Length}");
            
            Console.WriteLine($"Value of second index: {productDataList.GetData(2)}");

            DataDictionary<int, string> dataDictionary = new DataDictionary<int, string>(1, "küçük");
            dataDictionary.Add(2,"ömer");

            Console.WriteLine($"second keyitem: {dataDictionary.GetData(keyItem: 2)}");
            dataDictionary.Delete(1);
            
            foreach (var item in dataDictionary)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }

        private class Products
        {
            //Property - özellik
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string Details { get; set; }
            public int UnitInStock { get; set; }

            public override string ToString()
            {
                return $"Id:{Id} , Name: {Name} Price: {Price} Details: {Details} UnitInStock: {UnitInStock}";
            }
        }
    }
}
