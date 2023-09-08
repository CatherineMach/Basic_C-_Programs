using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
    //guessing a number
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isGuessed = number == 12;
            do
            {
    //the switch that only breaks when you guess 12
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 55:
                        Console.WriteLine("You guessed 55. Try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
    //defaults to saying "you are wrong" when guessing any other number
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }
            while (!isGuessed);

            int n = 0;
            while (n < 5)
            {
                Console.Write(n);
                n++;
            }


            Console.ReadLine();
         }
    }
}