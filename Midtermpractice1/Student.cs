using System;
using System.Collections.Generic;
using System.Text;

namespace Midtermpractice1
{
    public class Student : AcademicPerson
    {
        
        private bool myPencil;

        public Student(string firstname,string lastname):base(firstname,lastname) 
        {
        
        }
        public override string About()
        {
            return "Hello my name is "+FirstName+" "+LastName+" I am a student attending this school my ID number is "+ID;
        }

        public string Write()
        {
            return "";
        }

    }
}