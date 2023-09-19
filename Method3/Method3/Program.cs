using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Method3;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Nums = new Class1();
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