using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { FirstName = "Jessie", LastName = "Smith", Id = 1},
                new Employee() { FirstName = "Bill", LastName = "Wells", Id = 10},
                new Employee() { FirstName = "Joe", LastName = "Potter", Id = 6},
                new Employee() { FirstName = "Ken", LastName = "Anderson", Id = 2},
                new Employee() { FirstName = "Nick", LastName = "McIntosh", Id = 15},
                new Employee() { FirstName = "Joe", LastName = "McDonal", Id = 8},
                new Employee() { FirstName = "Amy", LastName = "Ginger", Id = 9},
                new Employee() { FirstName = "Abby", LastName = "Tran", Id = 22},
                new Employee() { FirstName = "Lam", LastName = "Lee", Id = 3},
                new Employee() { FirstName = "Joe", LastName = "Grand", Id = 4}
            };
            //employees.Add(new Employee() { FirstName = "Jessie", LastName = "Smith", Id = 1 });

            List<Employee> matched = new List<Employee>();
            foreach(Employee item in employees)
            {
                if (item.FirstName == "Joe")
                {
                    matched.Add(item);
                }
            }
            Console.WriteLine("Foreach Loop Joe list");
            foreach (Employee item in matched)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Id);//Output object;
            }



            List<Employee> joeList = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> idMatched = employees.Where(x => x.Id > 5).ToList<Employee>();//ToList<Employee>() can be simplified to ToList()
                                                                                         //var lambdaMatched = employees.Where(x => x.FirstName == "Joe").ToList<Employee>(); var is strongly typed implicit type
            Console.WriteLine("");
            Console.WriteLine("Lambda Joe list");
            foreach (Employee item in joeList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName +" "+ item.Id);//Output object;
            }

            Console.WriteLine("");
            Console.WriteLine("Lambda ID list");
            foreach (Employee item in idMatched)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Id}");//Output object: string interpolation
            }

            Console.ReadLine();
        }
    }
}
