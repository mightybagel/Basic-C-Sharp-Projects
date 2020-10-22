using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }
            Console.WriteLine("Please enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            if (length + height + width > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                return;
            }
            int charge =  (height * width * length * weight) /100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + charge + ".00 \nThank you!");
            Console.ReadLine();

        }
    }
}
