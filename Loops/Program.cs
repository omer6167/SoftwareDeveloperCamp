using System;

namespace Loops
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string course1 = "Yazılım Geliştirici Yetiştirme Kampı"; //Constant variable is not changable
            string course2 = "Programlamaya başlangıç için temel kurs";
            string course3 = "Java";
            string course4 = "Python";
            string course5 = "C++";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);
            Console.WriteLine(course5);


            //array - dizi

            string[] courses = { course1,
                "Programlamaya başlangıç için temel kurs",
                "Java", "Python", "C#" };


            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            // or
            foreach (var t in courses)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("Loop finished");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("End Of Page -- footer");
        }
    }
}
