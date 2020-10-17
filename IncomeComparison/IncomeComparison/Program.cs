using System;


namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous income comparison program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: 20");
            Console.WriteLine("Hours worked per week: 40");
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: 10");
            Console.WriteLine("Hours worked per week: 40");
            int salary1 = 20 * 40 * 52;
            int salary2 = 10 * 40 * 52;
            Console.WriteLine("Annual salary of Person 1 = " + salary1);
            Console.WriteLine("Annual salary of Person 2 = " + salary2);
            bool compareSalary = salary1 > salary2;
            Console.WriteLine("Does Person 1 make more money than Person 2 = " + compareSalary);
            Console.ReadLine();
        }
    }
}
