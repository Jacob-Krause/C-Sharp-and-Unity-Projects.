using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The current time is: ");
            Console.WriteLine(DateTime.Now);
            Console.Write("\nPlease enter a number: ");
            double userEntry = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nIn ");
            Console.Write(userEntry);
            Console.Write(" hour(s), the time will be: ");
            Console.WriteLine(DateTime.Now.AddHours(userEntry));
            Console.ReadLine();
        }
    }
}
