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
            Employee<string> employee1 = new Employee<string>() {ID = 1, FirstName = "Jacob", LastName = "Krause" };
            Employee<string> employee2 = new Employee<string>() { ID = 2, FirstName = "Megan", LastName = "Sakauye" };
            employee1.SayName();
            employee2.SayName();
            List<Employee<string>> employees = new List<Employee<string>>()
            {employee1,employee2 };

            bool compare = employee2 == employee1;

            Employee<string> newString = new Employee<string>();
            Employee<int> newInt = new Employee<int>();

            newString.Things = new List<string>() { "Badge", "Laptop", "Vest" };
            newInt.Things = new List<int>() {1,7,3 };

            int kk = newString.Things.Count;

            foreach (string stuff in newString.Things )
            {
                Console.Write(stuff);
                if (kk > 1)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("\n\n");
                }
                kk--;
            }
            int jj = newInt.Things.Count;

            foreach (int stuffs in newInt.Things)
            {
                Console.Write(stuffs);
                if (jj > 1)
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("\n\n");
                }
                jj--;
            }

            //For when an employee quits
            //IQuittable iQuit = new Employee();
            //iQuit.Quit();
            Console.ReadLine();
        }
    }
}
