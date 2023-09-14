using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();


            Console.WriteLine(obj.MathMethod(4));
            Console.WriteLine(obj.MathMethod(3.4m));
            Console.WriteLine(obj.MathMethod("33"));
        }
    }
}