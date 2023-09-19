using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Method3;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Nums = new Class1();
            int firstNum = Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(Nums.Total(firstNum, secondNum));
            }
            catch 
            {
                Console.WriteLine(Nums.Total(firstNum));
            }
            Console.ReadLine();
        }
    }
}