using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClassMethod number = new ClassMethod();
            Console.WriteLine("Please enter a number: ");
            int value = Convert.ToInt32(Console.ReadLine());
            number.OutputInteger(value);
            Console.ReadLine();
        }
        
    }
}
