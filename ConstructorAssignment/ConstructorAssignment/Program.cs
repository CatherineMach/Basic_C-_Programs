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

            const int num = 123;
            var name = "Donald Duck";

            Console.WriteLine(name + " " + num);

            Class1 a = new Class1(), b = new Class1("def", "kitchen"), c = new Class1("wow");

            Console.WriteLine(a.username + " " + a.location);
            Console.WriteLine(b.username + " " + b.location);
            Console.WriteLine(c.username + " " + c.location);

            Console.ReadLine();
        }
    }
}
