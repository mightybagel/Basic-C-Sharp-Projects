using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethod
{
    class Program
    {

        public static void Main(string[] args)
        {
            Calculations num = new Calculations();
            Console.WriteLine("The total of the entered numbers and 25 = " + num.Cal(25));
            Console.WriteLine("The difference of the entered numbers and 5 = " + num.Cal(25.26m));
            Console.WriteLine("The product of the entered numbers and 6 = " + num.Cal("15"));
            Console.ReadLine();
        }
    }
}
