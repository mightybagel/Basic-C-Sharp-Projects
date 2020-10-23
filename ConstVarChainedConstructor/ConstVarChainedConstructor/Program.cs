using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConstVarChainedConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string title = "Employee List";
            
            var employee = new List<Employee>()
            {
                new Employee(),
                new Employee("Lane", "Chan"),
                new Employee("Bill", "Wells"),
                new Employee("Joe", "Potter"),
                new Employee("Ken", "Anderson"),
            };
            //new Employee() constructor for Employee employee
            //    new Employee() { FirstName = "Jessie", LastName = "Smith" },
            //    new Employee() { FirstName = "Bill", LastName = "Wells" },
            //    new Employee() { FirstName = "Joe", LastName = "Potter" },
            //    new Employee() { FirstName = "Ken", LastName = "Anderson" },
            //    new Employee() { FirstName = "Nick", LastName = "McIntosh" },
            //    new Employee() { FirstName = "Joe", LastName = "McDonal" },
            //    new Employee() { FirstName = "Amy", LastName = "Ginger" },
            //    new Employee() { FirstName = "Abby", LastName = "Tran" },
            //    new Employee() { FirstName = "Lam", LastName = "Lee" },
            //    new Employee() { FirstName = "Joe", LastName = "Grand" }
            //};
            Console.WriteLine(title);
            foreach (Employee item in employee)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
