using System;


namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");//Output a line of text to screen 
            String name = Console.ReadLine();//Wait for the user's input
            Console.WriteLine("\"Hello, " + name + "!\"");
            Console.Read();//Wait for input
        }
    }
}
 