using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
                Id = 1
            };

            Employee employee2 = new Employee()
            {
                firstName = "Sample",
                lastName = "Student2",
                Id = 2
            };

            employee.SayName();
            IQuittable quitter = new Employee();
            quitter.Quit();

            Console.WriteLine(employee == employee2);

            Console.ReadLine();
            


        }
    }
}