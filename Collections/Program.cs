using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*  Array */
            //string[] names = new string[] { "Ömer", "Gürkan", "Mahmut" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            //names = new string[4];
            //names[4] = "NewName";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);


            /* Collections */
            List<string> newNames = new List<string>
            {
                "Ömer", "Gürkan", "Mahmut"
            };
            newNames.Add("newName");
            Console.WriteLine(newNames[0]);
            Console.WriteLine(newNames[1]);
            Console.WriteLine(newNames[2]);
            Console.WriteLine(newNames[3]);

            Dictionary<int, string> newDictionary = new Dictionary<int, string>
            {
                {2,"2"},
                {5,"5"}
            };
        }
    }
}
