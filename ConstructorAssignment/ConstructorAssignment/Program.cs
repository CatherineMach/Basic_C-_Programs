using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConstructorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 Class1 = new Class1();
            Class1 a = new Class1(), b = new Class1("def"), c = new Class1("wow"), d = new Class1("abc");

        }
    }
}
