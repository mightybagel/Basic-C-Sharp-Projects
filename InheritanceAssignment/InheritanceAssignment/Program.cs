﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.FirstName = "Sample";
            e.LastName = "Student";
            e.SayName();
            Console.ReadLine();
        }
    }
}
