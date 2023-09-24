using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public abstract class Person
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }

        public abstract void SayName();


    }
}
