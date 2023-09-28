using System;
using System.Linq;

namespace LAMBDAAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){FirstName = "Catherine", LastName = "Machado", Id = 1 },
                new Employee(){FirstName = "Joe", LastName = "Withers", Id = 2 },
                new Employee(){FirstName = "Sarah", LastName = "Smith", Id = 3 },
                new Employee(){FirstName = "Luis", LastName = "Elm", Id = 4 },
                new Employee(){FirstName = "Joe", LastName = "Patterson", Id = 5 },
                new Employee(){FirstName = "Harry", LastName = "Potter", Id = 6 },
                new Employee(){FirstName = "Ron", LastName = "Weasley", Id = 7 },
                new Employee(){FirstName = "Hermoine", LastName = "Granger", Id = 8 },
                new Employee(){FirstName = "Tom", LastName = "Riddle", Id = 9 },
                new Employee(){FirstName = "Luna", LastName = "Lovegood", Id = 10 }


            };
            List<Employee> JoeList = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    JoeList.Add(emp);
                }
            }
            foreach (Employee emp in JoeList)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.Id);
            }
            List<Employee> JoeList2 = employees.Where(x => x.FirstName == "Joe" ).ToList();

            foreach (Employee emp in JoeList2)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.Id);
            }

            List<Employee> IdList = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee emp in IdList)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.Id);
            }


        }

    }

}
