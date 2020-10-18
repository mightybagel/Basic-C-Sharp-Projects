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
        /// <summary>
        /// Get quotient based on given numbers
        /// </summary>
        /// <param name="num1">the first number</param>
        /// <param name="num2">the second number</param>
        /// <param name="result">The out result. will be 0 if failure. If success, will be the result of the division</param>
        /// <returns> true if division successful. Otherwise, false </returns>
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
