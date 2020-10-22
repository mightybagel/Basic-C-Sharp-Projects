using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApprovalProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int yearsOld = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI? Answer true or false");
            string DUI = Console.ReadLine();
            bool DUIViolation = Convert.ToBoolean(DUI);
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTicket = Console.ReadLine();
            int tickets = Convert.ToInt32(speedingTicket);
            bool approved = (yearsOld > 15 && (!DUIViolation) && tickets <= 3);
            Console.WriteLine("Qualify?");
            Console.WriteLine(Convert.ToString(approved));
            Console.ReadLine();
        }
    }
}
