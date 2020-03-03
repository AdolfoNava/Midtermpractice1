using Midtermpractice1.Models;
using System;

namespace Midtermpractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Courses OOP = new Courses();
            Courses ENG101 = new Courses() {CourseName ="Writing and Rhetoric I",CourseNumber = "101-01"};

            Instructor Jeff = new Instructor("Jeff", "Meyers");
            Jeff.ID = "10212";
            Student Kevin = new Student("Kevin", "Martinez");
            Kevin.ID = "00214";

            

            Console.WriteLine(Jeff.About());
            Console.WriteLine(Kevin.About());
        }
    }
}
