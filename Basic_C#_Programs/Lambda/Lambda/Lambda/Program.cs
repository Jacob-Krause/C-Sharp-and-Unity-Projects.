using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>() { ID = 1, FirstName = "Jacob", LastName = "Krause" };
            Employee<string> employee2 = new Employee<string>() { ID = 1, FirstName = "Megan", LastName = "Sakauye" };
            Employee<string> employee3 = new Employee<string>() { ID = 2, FirstName = "Joe", LastName = "Smith" };
            Employee<string> employee4 = new Employee<string>() { ID = 3, FirstName = "Isaiah", LastName = "Johnson" };
            Employee<string> employee5 = new Employee<string>() { ID = 4, FirstName = "Remy", LastName = "Patterson" };
            Employee<string> employee6 = new Employee<string>() { ID = 5, FirstName = "Joe", LastName = "Jones" };
            Employee<string> employee7 = new Employee<string>() { ID = 6, FirstName = "Bella", LastName = "Gonzalez" };
            Employee<string> employee8 = new Employee<string>() { ID = 7, FirstName = "Oliver", LastName = "Rodriguez" };
            Employee<string> employee9 = new Employee<string>() { ID = 8, FirstName = "Jane", LastName = "Samuels" };
            Employee<string> employee10 = new Employee<string>() { ID = 9, FirstName = "Joe", LastName = "Roland" };

            employee1.SayName();
            employee2.SayName();
            employee3.SayName();
            employee4.SayName();
            employee5.SayName();
            employee6.SayName();
            employee7.SayName();
            employee8.SayName();
            employee9.SayName();
            employee10.SayName();
            

            List<Employee<string>> employees = new List<Employee<string>>()
            {employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10};

            List<Employee<string>> NewJoe = new List<Employee<string>>();

            foreach (Employee<string> employee in employees)
            {
                if (employee.FirstName == "Joe")
                    {
                    NewJoe.Add(employee);
                    }
            }
            Console.WriteLine("\nEach 'Joe' from new list:");
            foreach (Employee<string> employee in NewJoe)
            {
                Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
            }

            Console.WriteLine("\nEach 'Joe' from new list using the lambda function:");
            List<Employee<string>> NewJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee<string> employee in NewJoe2)
            {
                Console.WriteLine("{0} {1}",  employee.FirstName, employee.LastName);
            }
            Console.WriteLine("\nEvry employee with an ID above 5 using a lambda function:");
            List<Employee<string>> IdAboveFive = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee<string> employee in IdAboveFive)
            {
                Console.WriteLine("{0} {1} {2}", employee.FirstName, employee.LastName, employee.ID);
            }
            Console.WriteLine("");
            //bool compare = employee2 == employee1;
            //bool compare2 = employee9 == employee8;

            Employee<string> newString = new Employee<string>();
            Employee<int> newInt = new Employee<int>();

            newString.Things = new List<string>() { "Badge", "Laptop", "Vest" };
            newInt.Things = new List<int>() { 1, 7, 3 };

            int kk = newString.Things.Count;

            foreach (string stuff in newString.Things)
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
