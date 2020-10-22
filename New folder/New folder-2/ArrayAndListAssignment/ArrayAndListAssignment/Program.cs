using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
            Console.WriteLine("Please choose a number from 0 - 9.");
            string answer = Console.ReadLine();
            int index = Convert.ToInt32(answer);
            if (index < 0 || index > 9)
            {
                Console.WriteLine("The data does not exist");
             
            }
            else
            {
                Console.WriteLine("Here is what you chose: " + stringArray[index]);
            }
            

            int[] intArray = new int[] { 32, 62, 50, 25, 100, 2560, 2552 };
            Console.WriteLine("Please choose a number from 0 - 6.");
            string intAnswer = Console.ReadLine();
            int intIndex = Convert.ToInt32(intAnswer);
            if (intIndex < 0 || intIndex > 6)
            {
                Console.WriteLine("The data does not exist");
            }
            else
            {
                Console.WriteLine("Here is the number you chose: " + intArray[intIndex]);
            }
           
            List<string> alist = new List<string>();
            alist.Add("54");
            alist.Add("HELLO");
            Console.WriteLine("Please choose a number.");
            string listAnswer = Console.ReadLine();
            int listIndex = Convert.ToInt32(listAnswer);
            if (listIndex < 0 || listIndex > 1)
            {
                Console.WriteLine("The data does not exist");
            }
            else
            {
                Console.WriteLine("Here is what you chose: " + alist[listIndex]);
            }
            
            Console.ReadLine();

          

        }
    }
}
