using System;

namespace WhileLoop
{
    class Program
    {
        static void Main()
        {
            bool Again = false; 
            int Num1 = 1; 
            int Num2 = 1;

            // Starting statement
            Console.WriteLine("We are going to play a game all you have to do is guess a number.");

            // Do while loop
            do
            {
                bool rightNum = false; 

                // Right Number loop
                while (!rightNum) 
                {
                    Console.WriteLine("");
                    Console.WriteLine("Round " + Num1.ToString()); 
                    Console.WriteLine(""); 
                    int ranNum = new Random().Next(1, 11);
                    int userNum = 1; 

                    // Validating loop
                    while (true) 
                    {
                        Console.Write("Please guess a number between 1 and 10:     ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        if (number >= 1 && number <= 10)
                        {
                            userNum = number;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                        } 
                    }

                    if (userNum == ranNum)
                    {
                        Console.WriteLine("You have guessed the right number!");
                        Console.WriteLine("You Win!");

                        while (true)
                        {
                            Console.Write("Would you like to paly again (yes or no):     ");
                            string again = Console.ReadLine();


                            if (again == "yes")
                            {
                                Num1 = 1;
                                Num2++;
                                Console.WriteLine("");
                                Console.WriteLine("Restarting ...");
                                Console.WriteLine("A new game is ready, press enter.");
                                Console.ReadLine();
                                Console.WriteLine("");
                                Console.WriteLine("Game " + Num2.ToString());
                                Again = true;
                                break;
                            }
                            else if (again == "no")
                            {
                                Console.WriteLine("Understandable thank you for playing!");
                                Again = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid input and try again (no caps).");
                            }
                        }

                        rightNum = true;
                    }

                    else
                    {
                        Num1++;
                        Console.WriteLine("You guessed inccorectly.");
                        Console.WriteLine("Please try again.");
                        Console.WriteLine("Press enter.");
                        Console.ReadLine();
                    }
                }
            }

            while (Again == true);
            Console.ReadLine();
        }
    }
}