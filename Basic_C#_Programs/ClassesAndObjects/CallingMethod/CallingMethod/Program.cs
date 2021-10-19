using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethod
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.Write("Please enter a number:   ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            var operationsObj = new Operations();

            int ans = operationsObj.Add(userNum, 5);
            int ans1 = operationsObj.Subtract(ans, 1);
            int ans2 = operationsObj.Divide(ans1, 10);


            Console.WriteLine("");
            Console.WriteLine("If you add " + userNum + " to 5 the answer equals: " + ans);
            Console.WriteLine("Subtract 1 from " + ans + " equals: " + ans1);
            Console.WriteLine("Divide 10 by " + ans1 + " equals: " + ans2);


            Console.WriteLine("");
            Console.Write("Please enter a decimal number:   ");
            var userDValue = Convert.ToDouble(Console.ReadLine());

            double r = operationsObj.Decimal(userDValue, 5.5);

            Console.WriteLine("");
            Console.WriteLine(userDValue + " multiplied by 5.5 is " + r);

            Console.ReadLine();
        }
    }
}
