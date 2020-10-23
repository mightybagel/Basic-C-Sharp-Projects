using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age: ");
                string userInput = Console.ReadLine();
                int age = Convert.ToInt32(userInput);
                if(age <= 0)
                {
                    throw new ArgumentException();
                }
                //DateTime today = new DateTime(2020, 10, 22);
                int year = DateTime.Now.Year;
                int birthYear = year - age;
                Console.WriteLine("This is your birth year: " + birthYear);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Age should not be zero or less than zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("This is not a number. Please enter only a number");
            }
            Console.ReadLine();

        }
    }
}
