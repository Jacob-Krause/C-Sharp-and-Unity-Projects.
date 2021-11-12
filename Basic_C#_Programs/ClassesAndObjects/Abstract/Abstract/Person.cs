using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
     public abstract class Person
    {
        string FirstName = "Sample";
        string LastName = "Student";

        public virtual void SayName()
        {
            Console.WriteLine("FirstName: {0}", FirstName);
            Console.WriteLine("LastName: {0}", LastName);
            Console.ReadLine();
        } 
    }
}
