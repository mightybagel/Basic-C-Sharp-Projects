using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
   public class Number
    {
        
        public int Sum(int num1)
        {
            int total = num1 + 25;
            return total;
        }

        public int Difference (int num1)
        {
            int difference = num1 - 5;
            return difference;
        }

        public int Product(int num1)
        {
            int product = num1 * 6;
            return product;
        }
    }
}
