using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InputAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The date and time now is " + DateTime.Now);
            Console.WriteLine("Type a number");
            int userText = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\flowe\source\numberpicked.txt", true))
            {
                file.Write(DateTime.Now);
                file.WriteLine(userText);
            }
            Console.WriteLine("The Time will be : " + DateTime.Now.AddHours(userText) + " " + userText + " hours from now.");


        }

    }
}