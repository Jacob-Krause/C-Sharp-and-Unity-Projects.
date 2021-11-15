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
            Employee employee = new Employee();
            employee.SayName();
            IQuittable iQuit = new Employee();
            iQuit.Quit();
            Console.ReadLine();
        }
    }
}
