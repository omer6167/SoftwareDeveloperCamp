using System;

namespace GenericsIntro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Ömer");

            Console.WriteLine(names.Length);

            names.Add("Küçük");

            Console.WriteLine(names.Length);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
