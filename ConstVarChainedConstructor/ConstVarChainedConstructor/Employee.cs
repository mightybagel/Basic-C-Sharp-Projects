using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarChainedConstructor
{
    public class Employee
    {
        
        //Chain constructor to initialize object in this case
        public Employee() : this("Joe", "Martin")
        {
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Id}";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        

    }
}
