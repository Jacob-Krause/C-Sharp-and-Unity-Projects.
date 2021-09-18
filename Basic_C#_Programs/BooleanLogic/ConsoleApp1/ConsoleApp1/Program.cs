using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            //Heading
            Console.WriteLine("Are you qualified for car insurance?");
            Console.WriteLine("");

            //Age
            Age:
            Console.Write("How old are you?:     ");
            short age;
            try
            {
                age = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid Age.");
                goto Age;
            }

            //DUI
            bool DUI = true; 
            while (true) 
            {
                Console.Write("Have you ever had a DUI? (please enter yes or no ):     ");
                string dui = Console.ReadLine(); 
                if (dui == "yes" || dui == "no") 
                {
                    if (dui == "yes")
                    {
                        DUI = false; 
                    }
                    else
                    {
                        DUI = true; 
                    }
                    break; 
                }
                else 
                {
                    Console.WriteLine("Please try again and enter a valid input (no caps)."); 
                } 
            }

        //Ticket
        Ticket:
            Console.Write("How many speeding tickets do you have?:     ");
            short Speed;
            try
            {
                Speed = Convert.ToInt16(Console.ReadLine()); 
            }
            catch
            {
                Console.WriteLine("Please enter a valid number of tickets");
                goto Ticket;
            }
            Console.WriteLine("");

            //Qualification
            if (age > 15 && DUI == true && Speed <= 3) 
            {
                Console.WriteLine("Congratulations you have qualified for car insurance!");
            }
            else
            {
                Console.WriteLine("Sorry you do not meet our qualifications. You can contact our help line for questions at 503-503-5033.");
            }
            Console.ReadLine();
        }
    }
}
