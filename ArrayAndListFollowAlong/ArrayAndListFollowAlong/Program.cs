using System;
using System.Collections.Generic;
 

namespace ArrayAndListFollowAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //Need to define length 
            //Use Array when has a small fixed quantities. Difficult to change the size when set
            //To store a very large quantities.
            int[] numArray = new int[5]; //set the size
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };//or not set a size but initialize 
            int[] numArray2 = {5, 2, 10, 200, 5000, 600, 2300}; // just initialize
            numArray2[5] = 650;

            Console.WriteLine(numArray[3]);
            Console.WriteLine(numArray1[3]);
            Console.WriteLine(numArray2[3]);
            Console.WriteLine(numArray2[5]);

            //Use byte array to store binary info
            //byte[] byteArray = new byte[5000];
           
            //List: create a list with any datatype. Hence, it is in the namespace Generic
            //List can be used with any types
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);
            Console.WriteLine(intList[0]);

            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("Jessie");
            stringList.Remove("Jessie");
            Console.WriteLine(stringList[0]);
            Console.ReadLine();




        }
    }
}
