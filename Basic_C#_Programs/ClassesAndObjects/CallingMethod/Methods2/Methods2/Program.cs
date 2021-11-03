using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations math = new Operations();
            Console.WriteLine("Please enter an integer.");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second integer (Optional).");
            string Input = Console.ReadLine();

            if (Input == "")
            {
                int ans = math.operations(a);
                Console.WriteLine("Since you have decided to not input a second number we have given you a second number of 5.");
                Console.Write(a + " * 5 = ");
                Console.WriteLine(ans);
            }
            else
            {
                int b = Convert.ToInt32(Input);
                int ans = math.operations(a, b);
                Console.WriteLine("We will nwo multiply your two numbers to get the product.");
                Console.Write(a + " * " + b + " = ");
                Console.WriteLine(ans);
            }

            Console.ReadLine();
        }
    }
}