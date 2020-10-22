using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time;
            time = DateTime.Now;
            Console.WriteLine(DateTime.Now);
            Console.Write("Please enter a number: ");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(time.AddHours(input));
            Console.ReadLine();
        }
    }
}
