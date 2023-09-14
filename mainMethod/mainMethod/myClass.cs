using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethod
{
    public class myClass
    {
        public int MathMethod(int num)
        {
            return num + 7;
        }

        public int MathMethod(decimal num)
        {
            return Convert.ToInt32(num) + 5;
        }

        public int MathMethod(string num)
        {
            Console.WriteLine("33");
            return Convert.ToInt32(num);
        }

    }
}
