using System;
using System.Collections.Generic;
using System.Text;

namespace Midtermpractice1.Models
{
    public class Courses
    {
        public string CourseName;
        public string CourseNumber;
        public Courses()
        {
            this.CourseName = "Object Oritented Programming";
            this.CourseNumber = "PROG 201";
        }
        public string About()
        {
            return"This is "+CourseName+" "+CourseNumber+" for the Spring semester.";
        }
    }
}
