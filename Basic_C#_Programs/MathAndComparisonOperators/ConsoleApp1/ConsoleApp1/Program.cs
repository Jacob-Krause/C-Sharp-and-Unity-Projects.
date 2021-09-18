using System;

namespace AnonymousIncome
{
    class Program
    {
        static void Main()
        {
            //Heading
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("");

            //Person 1 Info

            Console.WriteLine("Person 1");
            Person1Pay:
            Console.ReadLine();
            Console.Write("How much money are you paid an hour?:    ");
            Console.Write("$"); 
            decimal person1Hour;
            try
            {
                person1Hour = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a Decimal!");
                goto Person1Pay;
            }
        HourlyWage1:
            Console.Write("How many hours do you work per week?:     ");
            decimal person1Week;
            try
            {
                person1Week = Convert.ToDecimal(Console.ReadLine()); 
            }
            catch
            {
                Console.WriteLine("Please enter a Decimal!");
                goto HourlyWage1;
            }
            Console.WriteLine(""); 

            // Person 2 info

            Console.WriteLine("Person 2");
        Person2Pay:
            Console.ReadLine();
            Console.Write("How much do you get paid per hour?:    ");
            Console.Write("$");
            decimal person2Hour;
            try
            {
                person2Hour = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a Decimal!");
                goto Person2Pay;
            }
        HourlyWage2:
            Console.Write("How many hours do you work per week?:     ");
            decimal person2Week;
            try
            {
                person2Week = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a Decimal!");
                goto HourlyWage2;
            }
            Console.WriteLine("");

            // Calculations
            decimal person1Salary = (person1Hour * person1Week) * 52; 
            decimal person2Salary = (person2Hour * person2Week) * 52; 

            // Income display
            Console.Write("Person 1 your anual salary is: ");
            Console.WriteLine("$" + person1Salary.ToString());
            Console.Write("Person 2 your anual salary is: ");
            Console.WriteLine("$" + person2Salary.ToString());
            Console.WriteLine("");

            // Highest income
            bool highestSalary = person1Salary > person2Salary; 
            if (highestSalary == true) 
            {
                Console.WriteLine("Person 1 makes more money than Person 2"); 
            }
            else // If highestSal is false it runs this
            {
                Console.WriteLine("Person 2 makes more money than Person 1"); 
            }
            Console.ReadLine();
        }
    }
}