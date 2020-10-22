using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Calculations
    {
        public int Sum(int num1, int num2 = 7)
        {
            int total = num1 + num2;
            return total;
        }
    }
}
