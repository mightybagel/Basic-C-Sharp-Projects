using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();
            File.WriteAllText(@"..\..\Text\Number.txt",number);
            string text = File.ReadAllText(@"..\..\Text\Number.txt");
            Console.WriteLine("");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
