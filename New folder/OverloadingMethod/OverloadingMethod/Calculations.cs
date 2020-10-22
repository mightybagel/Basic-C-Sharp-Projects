using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethod
{
    public class Calculations
    {
        public int Cal(int num1)
        {
            int total = num1 + 25;
            return total;
        }
        public decimal Cal(decimal num1)
        { 
            decimal difference = num1 - 5;
            return difference;
        }

        public int Cal(string num1)
        {
            int product = Convert.ToInt32(num1) * 6;
            return product;
        }
    }
}


