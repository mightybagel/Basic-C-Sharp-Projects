using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Part One
            Console.WriteLine("Part One");
            string[] fruits = new string[] { "apple", "kiwi", "banana" };
            Console.WriteLine("Please enter some text: ");
            string input = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                fruits[i] = fruits[i] + input;
            }
            foreach (string text in fruits)
            {
                Console.WriteLine(text);
            }

            //Part Two
            Console.WriteLine("\nPart Two");
            int index = 0;
            while (index < fruits.Length)
            {
                if (fruits[index].StartsWith("apple"))
                {
                    fruits[index] = "cherry";

                }
                index++;
            }
            foreach (string text in fruits)
            {
                Console.WriteLine(text);
            }

            //Part Three
            Console.WriteLine("\nPart Three");
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i <= 1; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            //Part Four
            Console.WriteLine("\nPart Four");
            List<string> storeLists = new List<string>() { "wal-mart", "heb", "kroger", "costco" };
            Console.WriteLine("Please enter the name of the store: ");
            string storeName = Console.ReadLine().ToLower();
            bool isFound = false;
            for (int i = 0; i < storeLists.Count; i++)
            {
                if (storeLists[i] == storeName)
                {
                    Console.WriteLine("The name you entered is " + i + " index");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Store name '" + storeName + "' is not in the list");
            }

            //Part Five
            Console.WriteLine("\nPart Five");
            List<string> brandLists = new List<string>() { "JBL", "APPLE", "BEAT", "APPLE" };
            List<int> indices = new List<int>();
            Console.WriteLine("Please enter the name of the tech brand: ");
            string techName = Console.ReadLine().ToUpper();
            for (int i = 0; i < brandLists.Count; i++)
            {
                if (brandLists[i] == techName)
                {
                    indices.Add(i);
                }
            }
            if (indices.Count > 0)
            {
                Console.Write("The name you entered is found at: ");
                foreach (int i in indices)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(techName + " you entered is not found");
            }
            
            //Part Six
            Console.WriteLine("\nPart Six");
            List<string> candyTypes = new List<string>() { "chocolates", "lollipops", "caramels", "gum balls", "licorices", "lollipops" };
            List<string> appearedWords = new List<string>();
            foreach(string type in candyTypes)
            {
                if (appearedWords.Contains(type))
                {
                    Console.WriteLine(type + " has appeared already.");
                }
                else
                {
                    Console.WriteLine(type + " has not appeared.");
                    appearedWords.Add(type);
                }
            }

            Console.ReadLine();
        }
    }
}
