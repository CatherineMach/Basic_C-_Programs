using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
     class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            Console.WriteLine("Please enter a number to do some math on: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number + " plus 7 is " + obj.Addition(number));
            Console.WriteLine(number + " subtracted by 7 is " + obj.Subtraction(number));
            Console.WriteLine(number + " multiplied by 7 is " + obj.Multiply(number));

            Console.ReadLine();
        }
    }
}
