using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract 
{
    public class Employee<T> : Person, IQuittable
    {
        public int ID { get; set; }
        public List<T> Things;
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("This Employee has resigned");
        }

        public static bool operator == (Employee<T> One, Employee<T> Two)
        {
            if (One.ID == Two.ID)
            {
                Console.WriteLine("The ID's of these two employees are the same.");
                return true;
            }
            else
            {
                Console.WriteLine("The ID's of these two employees are differnt.");
                return false;
            }
        }
        public static bool operator != (Employee<T> One, Employee<T> Two)
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
