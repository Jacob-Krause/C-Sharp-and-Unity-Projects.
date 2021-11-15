using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() {ID = 1, FirstName = "Jacob", LastName = "Krause" };
            Employee employee2 = new Employee() { ID = 2, FirstName = "Megan", LastName = "Sakauye" };
            employee1.SayName();
            employee2.SayName();
            //For when an employee quits
            //IQuittable iQuit = new Employee();
            //iQuit.Quit();
            Console.ReadLine();
        }
    }
}
