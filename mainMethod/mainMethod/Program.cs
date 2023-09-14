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

            Console.WriteLine("Enter a number to use for math equations");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number + " plus 5 is " + obj.Add(number));
            Console.WriteLine(number + " subtract by 5 is " + obj.Subtract(number));
            Console.WriteLine(number + " divided by 2 is " + obj.Divide(number));
            Console.WriteLine(number + " multiplied by 2 is " + obj.Multiply(number));
        }
    }
}