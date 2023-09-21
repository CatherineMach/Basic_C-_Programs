using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: "+ firstName + " " + lastName);
        }

    }
}
