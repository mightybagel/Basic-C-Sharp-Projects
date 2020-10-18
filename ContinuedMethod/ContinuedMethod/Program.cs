using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuedMethod
{
    class Program
    {

        public static void Main(string[] args)
        {
            Calculations num = new Calculations();
            num.Cal(25, 15);
            num.Cal(num1: 25, num2: 15);
           
            Console.ReadLine();
        }

    }
}
