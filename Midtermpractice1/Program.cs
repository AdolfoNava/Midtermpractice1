using Midtermpractice1.Models;
using System;

namespace Midtermpractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Courses OOP = new Courses();
            Instructor Jim = new Instructor();

            Console.WriteLine(OOP.About());
        }
    }
}
