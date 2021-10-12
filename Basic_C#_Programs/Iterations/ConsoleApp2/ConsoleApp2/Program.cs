using System;
using System.Collections.Generic;


namespace ConsoleAppAssignmentPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] car = { "Toyota", "Mazda", "Honda", "Jeep", "Acura", "Ford", "Jeep" };
            Console.WriteLine("Toyota, Mazda, Honda, Jeep, Acura, Ford \n from the list above type your brand:");
            String c = Console.ReadLine();
            int index = Array.IndexOf(car, c); //Indexof

            while (true)
                if (index > -1)
                {

                    Console.WriteLine(c + " can be found in index " + index);
                    break;
                }
                else
                {
                    Console.WriteLine(c + " is not in the list!");
                    break;
                }






            Console.ReadLine();
        }
    }
}