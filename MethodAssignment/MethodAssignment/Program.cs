using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Number num = new Number();
            Console.WriteLine("Enter the first number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The total of the entered numbers and 25 = " + num.Sum(userInput));
            Console.WriteLine("The difference of the entered numbers and 5 = " + num.Difference(userInput));
            Console.WriteLine("The product of the entered numbers and 6 = " + num.Product(userInput));
            Console.ReadLine();
        }
    }
}
