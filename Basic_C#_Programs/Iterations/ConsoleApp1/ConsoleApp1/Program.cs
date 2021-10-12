using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //String Array

            string[] stringArray = new string[4];
            Console.WriteLine("Iteration");
            Console.WriteLine();
            Console.WriteLine("We are going to ask you for strings that will be stored in an array.");
            Console.Write("Please enter in your first string.:     ");
            stringArray[0] = Console.ReadLine();
            Console.Write("Please enter your second string.:     ");
            stringArray[1] = Console.ReadLine();
            Console.Write("Please enter your third string.:     ");
            stringArray[2] = Console.ReadLine();
            Console.Write("Please enter one last string to complete your array.:     ");
            stringArray[3] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Now retriving your array. Press enter to veiw your selections.");
            Console.ReadLine();
            for (int j = 0; j < stringArray.Length; j++)
            {
                Console.WriteLine(stringArray[j]);
            }
            Console.WriteLine();

            //Testscore Array

            int[] numArray = new int[4];
            Console.WriteLine("Now you are going to create an array of testscores.");
            Console.Write("Please enter in your first testscore.:     ");
            numArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter in your second testscore.:     ");
            numArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter in your third testscore.:     ");
            numArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter in your final testscore.:     ");
            numArray[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int k = 0; k < numArray.Length; k++)
            {
                if (numArray[k] < 95)
                {
                    Console.WriteLine("Failing test score:" + numArray[k]);
                }
            }
            Console.WriteLine();

            //Age Array

            int[] AgeArray = new int[4];
            Console.WriteLine("Now you are going to create an array of Ages.");
            Console.Write("Please enter in your age.:     ");
            AgeArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter in your mothers age.:     ");
            AgeArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter in your fathers age.:     ");
            AgeArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter in your desired age.:     ");
            AgeArray[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int x = 0; x < AgeArray.Length; x++)
            {
                if (AgeArray[x] <= 61)
                {
                    Console.WriteLine("If someone is " + AgeArray[x] + " they are to young to apply for Social Security");
                }
            }

            //Meat List

            string[] ingrident = { "Chicken", "Turkey", "Beef", "Pork" };
            Console.WriteLine();
            Console.WriteLine("Now to pick some meat");
            Console.WriteLine();
            Console.WriteLine("Chicken, Turkey, Beef, Pork \n from the list of ingridients type your favorite meat:");
            String meat = Console.ReadLine();
            int index = Array.IndexOf(ingrident, meat);

            while (true)
                if (index > -1)
                {
                    Console.WriteLine(meat + " can be found in index " + index);
                    break;
                }
                else
                {
                    Console.WriteLine(meat + " is not in the list!");
                    break;
                }

            //Vegie List

            Console.WriteLine();
            String[] vegie = { "Corn", "Carrots", "Brocoli", "Peas", "Corn" };
            Console.WriteLine("Please Type in your Favorite Vegie:");
            String vg = Convert.ToString(Console.ReadLine());
            int v = 0;

            foreach (String vegies in vegie)
            {
                if (vg == vegies) v++;
                Console.WriteLine("There is {0}", v + " " + vg + " on the list...");
            }
            Console.WriteLine("Sorry there is no" + vg + " on the list!");

            //Yes No List

            Console.WriteLine();
            
                List<string> answer = new List<string>() { "Yes", "No", "Yes", "Yes", "Yes", "No", "No", "No", "No", "Yes" };
                List<string> emptya = new List<string>();

                foreach (string a in answer)
                {
                    if (emptya.Contains(a))

                        Console.WriteLine(a + " This has already appeared in the list.");

                    else if (!emptya.Contains(a))
                        Console.WriteLine(a + " This has not yet appeared in the list.");
                    emptya.Add(a);
                }
                Console.ReadLine();
        }
    }
}
