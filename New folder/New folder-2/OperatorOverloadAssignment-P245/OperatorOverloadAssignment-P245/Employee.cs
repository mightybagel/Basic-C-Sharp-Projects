using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment_P245
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public static bool operator==(Employee left, Employee right)
        {
            if (left.Id == right.Id)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Employee left, Employee right)
        { 
            if (left.Id != right.Id)
            {
                return true;
            }
            return false;
        }
        
    }

}
