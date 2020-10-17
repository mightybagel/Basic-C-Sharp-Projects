using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            int product = num * 50;
            int total = num + 25;
            double quotient = num / 12.5;
            Console.WriteLine("Product of input number and 50 = " + product);
            Console.WriteLine("Total of input number and 25 = " + total);
            Console.WriteLine("Quotient of input number and 12.5 = " + quotient);
            bool isGreaterThan50 = num > 50;
            Console.WriteLine("Input number is greater than 50 = " + isGreaterThan50);
            int remainder = num % 7;
            Console.WriteLine("Remainder of " + num + "/7 = " + remainder);
            Console.ReadLine();






        }
    }
}
