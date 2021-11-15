using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract 
{
    class Employee : Person, IQuittable
    {
        public int ID { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("This Employee has resigned");
        }

        public static bool operator == (Employee One, Employee Two)
        {
            if (One.ID == Two.ID)
            {
                Console.WriteLine("The ID's of these two employees are the same.");
                return true;
            }
            else
            {
                Console.WriteLine("The ID's of these two emplyees are differnt.");
                return false;
            }
        }
        public static bool operator != (Employee One, Employee Two)
        {
            if (One.ID == Two.ID)
            {
                Console.WriteLine("The ID's of these two employees are the same.");
                return true;
            }
            else
            {
                Console.WriteLine("The ID's of these two emplyees are differnt.");
                return false;
            }
        }
    }  
}
