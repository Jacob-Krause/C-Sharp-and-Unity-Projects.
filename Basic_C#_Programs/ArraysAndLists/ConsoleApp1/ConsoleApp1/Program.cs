using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
        //String Array

            string[] stringArray = new string[4];   
            Console.WriteLine("Arrays and lists");
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

        StringIndex:
            Console.Write("Please enter in a number from 0 to 3 and we will retrive the data in your array at that index.:     ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index > 3 || index < 0)     
            {
                Console.WriteLine("Please enter a valid number.");
                goto StringIndex;
            }
            Console.WriteLine("Now retriving that index. Press enter to veiw your selection.");
            Console.ReadLine();
            Console.WriteLine(stringArray[index]);  

        //Num Array

            Console.WriteLine();
            Console.WriteLine();
            int[] numArray = new int[4];    
            Console.WriteLine("Now you are going to create an array of integers.");
            Console.Write("Please enter in your first number.:     ");
            numArray[0] = Convert.ToInt32(Console.ReadLine());  
            Console.Write("Please enter in your second number.:     ");
            numArray[1] = Convert.ToInt32(Console.ReadLine());  
            Console.Write("Please enter in your third number.:     ");
            numArray[2] = Convert.ToInt32(Console.ReadLine());  
            Console.Write("Please enter in your last number.:     ");
            numArray[3] = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine();    

        NumArray:
            Console.Write("Please enter in a number from 0 to 3 and we will retrive the data in your array at that index.:     ");
            index = Convert.ToInt32(Console.ReadLine());
            if (index > 3 || index < 0) 
            {
                Console.WriteLine("Please enter a valid number.");
                goto NumArray;
            }
            Console.WriteLine("Now retriving that index. Please press enter to veiw your selection.");
            Console.ReadLine();
            Console.WriteLine(numArray[index]); 

            Console.WriteLine();
            Console.WriteLine();    
            List<string> stringList = new List<string>();   
            Console.WriteLine("Now we are going to create a list which can be what ever length we want it to be but, we will be limiting it to a length of 4.");
            Console.Write("Please enter a string.:     ");
            stringList.Add(Console.ReadLine()); 
            Console.Write("Please enter your second string.:     ");
            stringList.Add(Console.ReadLine()); 
            Console.Write("Please enter your third string.:     ");
            stringList.Add(Console.ReadLine()); 
            Console.Write("Please enter your last string.:     ");
            stringList.Add(Console.ReadLine()); 
            Console.WriteLine();

        //List

        List:
            Console.Write("Please enter in a number from 0 to 3 and we will retrive the data in your list at that index.:     ");
            index = Convert.ToInt32(Console.ReadLine());
            if (index > 3 || index < 0) 
            {
                Console.WriteLine("Please enter a valid number.");
                goto List;
            }
            Console.WriteLine("Now reteriving that index please press enter to veiw your selection.");
            Console.ReadLine();
            Console.WriteLine(stringList[index]);
            Console.ReadLine();
        }
    }
}