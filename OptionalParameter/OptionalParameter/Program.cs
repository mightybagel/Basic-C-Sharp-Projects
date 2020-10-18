using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculations num = new Calculations();
            Console.WriteLine("Enter the first number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The total of the 1st entered number " + userInput1 + " and optional parameter 7 = " + num.Sum(userInput1));
            Console.WriteLine("The total of " + userInput1 + " and " + userInput2 + " = " + num.Sum(userInput1,userInput2));
            Console.WriteLine("The total of the 2nd entered number " + userInput2 + " and optional parameter 7 = " + num.Sum(userInput2));

            Console.ReadLine();
        }

    }
}
