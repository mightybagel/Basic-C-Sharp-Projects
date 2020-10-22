using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            const string answer = "violet";
            Console.WriteLine("Guess a color?");
            string guessColor =Console.ReadLine().ToLower();
            bool isGuess = guessColor == answer;
            //bool isGuess = false;

            do
            {
                switch (guessColor)//Switch without while only runs once
                {
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again");
                        Console.WriteLine("Guess a color?");
                        guessColor = Console.ReadLine().ToLower();
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Try again");
                        Console.WriteLine("Guess a color?");
                        guessColor = Console.ReadLine().ToLower();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green. Try again");
                        Console.WriteLine("Guess a color?");
                        guessColor = Console.ReadLine().ToLower();
                        break;
                    case answer:
                        Console.WriteLine("You guessed " + answer + ". That is correct");
                        isGuess = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess a color?");
                        guessColor = Console.ReadLine().ToLower();
                        break;
                }
            }
            while (!isGuess);

            //Guess a shape game
            Console.WriteLine("");
            const string shapeAnswer = "square";
            Console.WriteLine("Guess a shape?");
            string guessShape = Console.ReadLine().ToLower();
            bool isCorrect = guessShape == shapeAnswer;
      
            while (!isCorrect)
            {
                switch (guessShape)//Switch without while only runs once
                {
                    case "rectangle":
                        Console.WriteLine("You guessed rectangle. Try again");
                        Console.WriteLine("Guess a shape?");
                        guessShape = Console.ReadLine().ToLower();
                        break;
                    case "triangle":
                        Console.WriteLine("You guessed triangle. Try again");
                        Console.WriteLine("Guess a shape?");
                        guessShape = Console.ReadLine().ToLower();
                        break;
                    case "circle":
                        Console.WriteLine("You guessed circle. Try again");
                        Console.WriteLine("Guess a shape?");
                        guessShape = Console.ReadLine().ToLower();
                        break;
                    case shapeAnswer:
                        Console.WriteLine("You guessed " + shapeAnswer + ". That is correct");
                        isCorrect = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess a shape?");
                        guessShape = Console.ReadLine().ToLower();
                        break;
                }
            }

            Console.Read();
        }
    }
}

