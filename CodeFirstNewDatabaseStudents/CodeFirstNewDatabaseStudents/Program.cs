using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabaseStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            using(SchoolContext ctx = new SchoolContext())//This is the current database
            {
                Grade grade = new Grade()
                {
                    GradeName = "First"
                };
                ctx.Grades.Add(grade);

                Student student = new Student()
                {
                    StudentName = "Bill Fred",
                    DoB = DateTime.Parse("1/1/2001"),
                    Grade = grade
                };
                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.ReadLine();
        }
    }
}
