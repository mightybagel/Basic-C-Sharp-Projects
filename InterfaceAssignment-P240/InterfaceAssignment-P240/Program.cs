﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment_P240
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.FirstName = "Sample";
            e.LastName = "Student";
            e.SayName();

            IQuittable man = new Employee();
            man.Quit();


            Console.ReadLine();
        }
    }
}
