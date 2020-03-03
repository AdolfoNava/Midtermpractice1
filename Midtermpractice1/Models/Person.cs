using System;
using System.Collections.Generic;
using System.Text;

namespace Midtermpractice1.Models
{
    public abstract class Person
    {
        public string FirstName, LastName;
        public Person(string firstname,string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            
        }
        public virtual string About()
        {
            return "";
        }

        public void SayHello()
        {
            
        }
    }
}
