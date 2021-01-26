using System;

namespace CampIntro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias

            string labelOfCategory = "Categories";
            int numbsOfStudent = 32000;
            double İnterestRate = 1.45;
            bool isLoginTheSystem = true;
            double yesterdaysDolar = 7.55;
            double todaysDolar = 7.55;

            if (yesterdaysDolar > todaysDolar)
            {
                Console.WriteLine("decrease Button");
            }
            else if (yesterdaysDolar < todaysDolar)
            {
                Console.WriteLine("Increase Button");
            }
            else
            {
                Console.WriteLine("NotChanged Button");
            }

            Console.WriteLine(isLoginTheSystem == true ? "User Settings Button" : "Login Button"); //Ternary Operator
            //Condition ? Block1(if its true) : Block2(İf its false)
            //koşul ? if durumunda çalışacak kod : else durmunda çalışacak kod

            Console.WriteLine(labelOfCategory);

            Console.ReadLine();
        }
    }
}
