using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 5, 6, 9 };

            
            try
            {
                Console.WriteLine("Please enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int result = number / input;
                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Finished try catch block");
            Console.ReadLine();
        }
    }
}
