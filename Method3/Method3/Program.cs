using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Method3;
using System.Xml.Schema;

namespace Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Nums = new Class1();

            Nums.Total(20, 5);

            Nums.Total(firstNum: 10, secondNum: 4);

        }

    }
}