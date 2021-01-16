using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "yazılımcı geliştirme kampı";
            string course2 = "yazılıma başlamak için temel kurs";
            string course3 = "java kursu";


            string[] courses = new string[]
            {
                "yazılımcı geliştirme kampı","yazılıma başlamak için temel kurs","java kursu","java","Python","C#","C++"
            };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("sayfa sonu");
        }
    }
}
