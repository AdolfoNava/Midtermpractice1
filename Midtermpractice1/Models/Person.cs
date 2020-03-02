using System;
using System.Collections.Generic;
using System.Text;

namespace Midtermpractice1.Models
{
    public abstract class Person
    {
        public string FirstName, LastName;
        public Person()
        {
            this.FirstName = "Jeff";
            this.LastName = "Meyers";
            this.ID = "47167";
        }
        void About()
        {

        }

        public void SayHello()
        {
            throw new System.NotImplementedException();
        }
    }
}
