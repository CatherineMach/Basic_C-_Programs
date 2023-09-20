using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;


namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

                Console.WriteLine("enter a number");
                int userNum = Convert.ToInt32(Console.ReadLine());


                class1.Divide(userNum / 2);
                class1.Divide(7, 8);
                class1.Message(out string animal);
                Console.WriteLine(animal);

                MyStatic.staticMethod();
            Console.ReadLine();
        }
    }
}