using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment_P245
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee first = new Employee() {Id = 15};
            Employee second = new Employee() { Id = 20 };
            Employee third = new Employee() { Id = 15 };
            
            if (first == second)
            {
                Console.WriteLine("First is equal to second");
            }
            else 
            {
                Console.WriteLine("First is not equal to second");
            }

            if (first == third)
            {
                Console.WriteLine("First is equal to third");
            }
            else
            {
                Console.WriteLine("First is not equal to third");
            }
            Console.ReadLine();

        }
    }
}
