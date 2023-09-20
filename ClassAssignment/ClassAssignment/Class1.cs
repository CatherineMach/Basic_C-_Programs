using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAssignment;

namespace ClassAssignment
{
    public class Class1
    {
        public void Divide(int userNumber)
        {
            int result = userNumber / 2;
            Console.WriteLine(result);
        }

        public void Divide(int userNumber, int userNumber2)
        {
            int result = userNumber + userNumber2;
            Console.WriteLine(result);
        }

        //out
        public void Message(out string animal)
        {
            animal = "hello I am a frog";

        }
    }
}
