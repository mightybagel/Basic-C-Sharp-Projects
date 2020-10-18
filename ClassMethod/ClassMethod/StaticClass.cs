using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    public static class StaticClass//static class has no instance only has static method and properties
        //Out parameter is used when returning more than one values
        //Do not need to initialize out parameter when the caller calls it but the method must give it a value b4 returning 
        
    {
        public static bool GetQuotient(int num1, int num2, out int result)
        {
            result = 0;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }
    }
}
