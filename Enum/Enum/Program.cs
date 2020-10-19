using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    public enum DayOfWeek 
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week: ");
                string day = Console.ReadLine();

                DayOfWeek currentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day, true);

            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();

            
        }
    }
}
