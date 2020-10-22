using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Append : at to the end
            string one = "Do what you can,";
            string second = " with what you have,";
            string third = " where you are.";
            string combined = one + second + third;
            Console.WriteLine(combined.ToUpper());
            StringBuilder sb = new StringBuilder();
            sb.Append("Paragraphs are the building blocks of papers. ");
            sb.Append("Many students define paragraphs in terms of length: a paragraph is a group of at least five sentences, a paragraph is half a page long, etc. ");
            sb.Append("In reality, though, the unity and coherence of ideas among sentences is what constitutes a paragraph.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
