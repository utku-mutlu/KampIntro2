using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "utku";
            int yas = 26;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.CourseTeacher = "Engin Demirog";
            course1.WatchNumber = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.CourseTeacher = "Kerem Varış";
            course2.WatchNumber = 64;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.CourseTeacher = "Berkay Bilgin";
            course3.WatchNumber = 80;

            Course course4 = new Course();
            course3.CourseName = "Python";
            course3.CourseTeacher = "Murat Kurtbogan";
            course3.WatchNumber = 100;

            // Console.WriteLine(course1.CourseName+" "+course1.CourseTeacher+" "+course1.WatchNumber);

            Course[] course = new Course[] 
            { 
                course1,course2,course3
            };
            foreach (Course cours in course)
            {
                Console.WriteLine(cours.CourseName+" "+cours.CourseTeacher);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string CourseTeacher { get; set; }
        public int WatchNumber { get; set; }
    }



}
