using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
                try
                {

                    List<int> number = new List<int>() { 5, 10, 15, 20, 25 };
                    List<int> number1 = new List<int>();
                    Console.Write(" Please Type a number:");
                    int anumber = Convert.ToInt32(Console.ReadLine());

                    foreach (int n in number)

                    {
                        int result = n / anumber;
                        Console.WriteLine(n + " divided by " + anumber + " equals " + result);
                    }
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message); 
                    Console.WriteLine("Please type a whole number."); 
                    return;
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please don't divide by zero");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }

                finally
                {
                    Console.ReadLine();
                }

        }
    }
}
