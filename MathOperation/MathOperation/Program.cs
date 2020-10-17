using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int first = 8;
        //    int second = 3;
        //    int total = first + second;
        //    int difference = first - second;
        //    int product = first * second;
        //    int quotient = first / second;
        //    Console.WriteLine("Total is " + total);
        //    Console.WriteLine("Difference is " + difference);
        //    Console.WriteLine("Product is " + product);
        //    Console.WriteLine("Quotient is " + quotient);
        //    Console.ReadLine();

            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.WriteLine(combined);

            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());

            int product = 10 * 5;
            Console.WriteLine("Ten times five =" + product);

            double quotient = 100 / 17;
            Console.WriteLine("Implicit conversion of 100 /17 = " + quotient);//This results in 5 although the quotient is double type. Implicit conversion due to 100 and 17 is int.

            double decimalQuotient = 100.0 / 17.0;
            Console.WriteLine("Quotient of 100.0 /17.0 = " + decimalQuotient);

            int remainder = 10 % 2;
            Console.WriteLine("Remainder of 10/2 = " + remainder);

            int remainder2 = 11 % 2;
            Console.WriteLine("Remainder of 11/2 = " + remainder2);

            bool trueOrFalse = 12 < 5;
            Console.WriteLine(trueOrFalse.ToString());

            int roomTemp = 70;
            int currentTemp = 70;
            bool isWarm = currentTemp >= roomTemp;
            Console.WriteLine(isWarm);

            bool isWarm2= currentTemp == roomTemp;
            Console.WriteLine(isWarm2);
            Console.ReadLine();

        }
    }
}
