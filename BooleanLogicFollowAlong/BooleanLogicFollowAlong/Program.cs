using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicFollowAlong
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("true && false = " + Convert.ToString(true && false));
            Console.WriteLine("true && true" + Convert.ToString(true && true));
            Console.WriteLine(false && false);
            Console.WriteLine(true || true);
            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);
            //XOR operator : 1 of them is true but not both 
            Console.WriteLine("true ^ true = " + Convert.ToString(true ^ true));
            Console.WriteLine("true ^ false = " + Convert.ToString(true ^ false));
            Console.WriteLine("false ^ true = " + Convert.ToString(false ^ true));
            Console.WriteLine("false ^ false = " + Convert.ToString(false ^ false));
            Console.ReadLine();
        }
    }
}
