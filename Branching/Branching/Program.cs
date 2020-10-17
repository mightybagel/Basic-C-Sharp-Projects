using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            int currentTemp = 70;
            int roomTemp = 70;
            if(currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temperature");
            }
            else if (currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer than room temperature");
            }
            else if (currentTemp < roomTemp)
            {
                Console.WriteLine("Room temperature is warmer than current temperature");
            }
            else 
            {
                Console.WriteLine("It is not exactly room temperature");
            }

            string result = roomTemp > currentTemp ? "Room temperature is warmer than current temperature" : "Current temperature is warmer than room temperature";
            Console.WriteLine(result);
            string comparisonResult = roomTemp == currentTemp ? "It is room temp" : "It is not room temp";
            Console.WriteLine(comparisonResult);

            int roomTemp2 = 70;
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemp2 = Convert.ToInt32(Console.ReadLine());
            if (currentTemp2 == roomTemp2)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemp2 > roomTemp2)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (currentTemp2 < roomTemp2)
            {
                Console.WriteLine("It is colder than room temperature.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            String result3 = favNum == 12 ? "You have an awesome number" : "You did not have an awesome number";
            Console.WriteLine(result3);
            Console.ReadLine();
        }
                
    }
}
