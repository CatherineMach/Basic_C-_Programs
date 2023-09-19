using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Method2;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            Class1 obj = new Class1();

            Console.WriteLine("input a number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("if you want input another number, if not press enter.");
                int userNum2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(obj.Sum(userNum1, userNum2));
            }
            catch
            {

                Console.WriteLine(obj.Sum(userNum1));
            }
            Console.ReadLine();
        }

    }
}