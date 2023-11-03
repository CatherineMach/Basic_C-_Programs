using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace StudentDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.Write("Enter a student name: ");
                var name = Console.ReadLine();

                var student = new Student { Name = name };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.Name
                            select s;

                Console.WriteLine("All students in the database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
        public class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public virtual List<Student> Students { get; set; }

        }
        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }
    }
}
