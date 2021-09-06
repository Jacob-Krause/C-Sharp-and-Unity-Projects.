using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {   //This Program spits a name back at you
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("What is your name:  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello," + name + " it is very nice to meet you my name is Computer!");
            Console.Read();
        }
    }
}
