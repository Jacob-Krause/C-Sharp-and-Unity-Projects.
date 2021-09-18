using System;

namespace ShippingStore
{
    class Program
    {
        static void Main()
        {
            int packingNumber;
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("");
        PackageWeight:
            Console.Write("Please enter in your packages weight:    ");
            string userString = Console.ReadLine(); 
            try
            {
                int userNum = Convert.ToInt16(userString);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your Package is way to heavy please enter a different package weight.");
                goto PackageWeight;
            }
            catch (FormatException) 
            {
                Console.WriteLine("Please enter a whole number greater then or equal to 1.");
                goto PackageWeight;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong please try again.");
                goto PackageWeight;
            }

            packingNumber = Convert.ToInt16(userString);

            if (packingNumber > 50)
            {
                Console.WriteLine(" This package is too heavy to be shipped via Package Express. Have a good day.");
                goto End;
            }

        PackageWidth:
            Console.Write("Please enter the width of the package:   ");
            string widthString = Console.ReadLine();
            try
            {
                int userNum = Convert.ToInt16(widthString); 
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your Package is way to wide please enter a different package width.");
                goto PackageWidth;
            }
            catch (FormatException) 
            {
                Console.WriteLine("Please enter a whole number greater then or equal to 1.");
                goto PackageWidth;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong please try again.");
                goto PackageWidth;
            }

        PackageHeight:
            Console.Write("Please enter the package height:         ");
            string heightString = Console.ReadLine();
            try
            {
                int userNum = Convert.ToInt16(heightString);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your Package is way to tall please enter a different package height.");
                goto PackageHeight;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number greater then or equal to 1.");
                goto PackageHeight;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong please try again");
                goto PackageHeight;
            }

        PackageLength:
            Console.Write("Please enter the package length:         ");
            string lengthString = Console.ReadLine();
            try
            {
                int userNum = Convert.ToInt16(lengthString);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your Package is way to long please enter a different package length.");
                goto PackageLength;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number greater then or equal to 1.");
                goto PackageLength;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong please try again.");
                goto PackageLength;
            }

            int width = Convert.ToInt16(widthString);
            int height = Convert.ToInt16(heightString);
            int length = Convert.ToInt16(lengthString);
            int dimensions = width + height + length; 

            if (dimensions > 50)
            {
                Console.WriteLine(" Your package is too big to be shipped via Package Express. Have a good day");
                goto End;
            }
            decimal Quote = (width * height * length * packingNumber) / 100;  
            Console.WriteLine("");
            Console.Write("To ship this package it would cost ");
            Console.WriteLine("${0}", Quote);
        End:
            Console.ReadLine();
        }
    }
}
