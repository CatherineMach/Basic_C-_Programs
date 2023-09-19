using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    public class Class1
    {
        public static void Sum(int firstNum, int secondNum, params object[] restOfNums)
        {
            int result = firstNum + secondNum;
            if (secondNum != null)
            {
                foreach (int i in restOfNums)
                   {
                      result += i;
                   }
            }
            

            Console.WriteLine("Total is... " + result.ToString());
        }

        public static void Main()
        {
            
        }
    }
}
