﻿using InterfaceAssignment_P240;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment_P240
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("I quit");
        }
    }
}


