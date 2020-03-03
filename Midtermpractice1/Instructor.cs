using System;
using System.Collections.Generic;
using System.Text;

namespace Midtermpractice1
{
    public class Instructor : AcademicPerson
    {
        

        public  Instructor(string firstname,string lastname):base(firstname,lastname)
        {
            
        }

        public override string About()
        {
            return"Hello my name is "+FirstName+" "+LastName+" I am a teacher here in this school and my ID number is "+ID;
        }
    }
}