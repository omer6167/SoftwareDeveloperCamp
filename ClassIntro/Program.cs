using System;

namespace ClassIntro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = "Engin";
            int age = 36;

            Course kurs1 = new Course
            {
                CourseName = "C#",
                Educator = "Engin Demiroğ",
                ViewRate = 68
            };

            Course kurs2 = new Course
            {
                CourseName = "Java",
                Educator = "Kerem Varış",
                ViewRate = 64
            };

            Course kurs3 = new Course
            {
                CourseName = "Python",
                Educator = "Berkay Bilgin",
                ViewRate = 80
            };

            Course kurs4 = new Course
            {
                CourseName = "C++",
                Educator = "Murat Kurtboğan",
                ViewRate = 100
            };

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Course[] courses = { kurs1, kurs2, kurs3, kurs4 };

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.CourseName} {course.Educator}");
            }
        }

        class Course
        {
            public string CourseName { get; set; }
            public string Educator { get; set; }
            public int ViewRate { get; set; }
        }
    }
}
