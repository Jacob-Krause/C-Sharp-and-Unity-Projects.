using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            enterDay:
            try
            {
                Console.Write("Please enter the current day of the week: ");
                WeekDays Day = (WeekDays)Enum.Parse(typeof(WeekDays), Console.ReadLine(), true);
                Console.WriteLine("The day of the week you chose is {0}", Day.ToString());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nPlease enter an actual day of the week.\n");
                    goto enterDay;
            }
            Console.ReadLine();
        }
        public enum WeekDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
