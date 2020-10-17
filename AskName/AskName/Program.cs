using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskName
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Control + K + C: add comment symbols on multiple lines
            //Control + K + U: remove comments
            //Console.ReadLine() only takes in string
            //console.writeline("what is your name?");
            //string name = console.readline();
            //Console.writeline("your name is " + name);
            //Console.readline();

            //Console.WriteLine("What is your favorite number? ");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is " + total);
            //Console.ReadLine();

            //char questionMark = '\u2103';
            //Console.WriteLine(questionMark);
            //Console.ReadLine();

            //decimal moneyInBank = 100.5m; //need many decimal point to avoid loosing money due to rounding
            //double height = 21.0000000222355;
            //float second = 2.62f;
            //short temp = -342;//smaller than int

            //Casting
            bool isRaining = true;
            string rainingStatus = isRaining.ToString();
            Console.WriteLine(rainingStatus);

            int currentAge = 30;
            string yearsOld = Convert.ToString(currentAge);
            Console.WriteLine(yearsOld);
            Console.ReadLine();

            


        }
    }
}
