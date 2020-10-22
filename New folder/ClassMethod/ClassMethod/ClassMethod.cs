using ClassMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class ClassMethod
    {
        public void OutputInteger(int num)
        {
            //call static class by using class name
            if (StaticClass.GetQuotient(num, 2, out int quotient))
            {
                Console.WriteLine("The quotient of " + num + " and 2 = " + quotient);
            }
            else
            {
                Console.WriteLine("Error occurred while getting quotient");
            }
        }

        public void OutputInteger(long num)
        {
            long quotient = num / 2;
            Console.WriteLine("The quotient of " + num + " and 2 = " + quotient);
        }

    }
}
