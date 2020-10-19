using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> e = new Employee<string>();
            Employee<int> emp = new Employee<int>();
            e.things = new List<string>() { "Jessie", "Bob", "Nick"};
            emp.things = new List<int>() { 1, 3, 15 };

            foreach(string name in e.things)
            {
                Console.WriteLine(name);
            }
            foreach (int number in emp.things)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();


        }
    }
}
