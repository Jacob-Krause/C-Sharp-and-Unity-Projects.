using System;

    class Program
    {
        static void Main()
        {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("What is your name:  ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("What course are you on:  ");
        string course = Console.ReadLine();
        Console.WriteLine();
        Console.Write("What page number:    ");
        short pagenumber = Convert.ToInt16 (Console.ReadLine());
        Console.WriteLine();
        Console.Write("Do you need help with anything? (Please answer true or false.):    ");
        bool help = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine();
        Console.Write("How many hours did you study today:    ");
        float hour = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day! This is the end of the program.");
        Console.Read();
        }
    }   

