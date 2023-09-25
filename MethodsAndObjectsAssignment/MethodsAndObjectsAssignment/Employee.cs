using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " +  lastName);
        }

        public void Quit()
        {
            Console.WriteLine("This employee quit!");
        }

        public static bool operator == (Employee a, Employee b)
        {
            return a.Id == b.Id;
        }

        public static bool operator != (Employee a, Employee b)
        {
            return a.Id != b.Id;
        }
    }

    
}
