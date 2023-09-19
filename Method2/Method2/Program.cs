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
            //instantiate a class
            Class1 obj = new Class1();

            //asking for 2 numbers but the 2nd number they dont have to enter anything
            Console.WriteLine("input a number");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("if you want input another number, if not press enter.");
                int userNum2 = Convert.ToInt32(Console.ReadLine());

            //if user hits enter it will pull the method and automatically make the number be 5
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