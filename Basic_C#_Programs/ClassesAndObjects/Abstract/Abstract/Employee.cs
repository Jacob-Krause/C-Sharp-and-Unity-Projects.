using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract 
{
    class Employee : Person
    {
        public static int id = 1;
        string FirstName = "Sample";
        string LastName = "Student";
        public override void SayName()
        {
            base.SayName();

        }
    }  
}
