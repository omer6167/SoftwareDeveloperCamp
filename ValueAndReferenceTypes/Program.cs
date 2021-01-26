using System;

namespace ValueAndReferenceTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*Value Types: int,decimal,float,double,bool  */

            int numb1 = 10;
            int numb2 = 30;
            Console.WriteLine(numb1);
            //numb1 = 10
            numb1 = numb2;
            numb2 = 65;
            //numb1 = 30
            //numb2 = 65
            Console.WriteLine(numb1);
            Console.WriteLine(numb2);


            /*Reference Types: Array,Class,İnterface  */

            int[] numbs1 = { 10, 20, 30 };
            int[] numbs2 = { 100, 200, 300 };
            Console.WriteLine(numbs1[0]);
            //numbs1[0] = 10;
            numbs1 = numbs2;
            numbs2[0] = 999;
            //numbs1[0] = 999;
            //numbs2[0] = 999;
            Console.WriteLine(numbs1[0]);
            Console.WriteLine(numbs2[0]);


            Console.ReadLine();
        }
    }
}
