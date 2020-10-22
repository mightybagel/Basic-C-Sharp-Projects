using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFollowAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Immutable string: dynamic string object using string builder class. This relates to object and class
            StringBuilder SB = new StringBuilder();
            SB.Append("My name is Jessie");
            Console.WriteLine(SB);
            Console.ReadLine();

        }
    }
}
