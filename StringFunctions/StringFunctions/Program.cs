using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Catherine";
            string quote = "The man said, \"Hello\", Catherine. \n Hello on a new line. \n \t Hello on a tab.";
            string fileName = "C:\\Users\\Catherine"; // OR you can do string fileName = @"C:\Users\Catherine";

            bool trueOrFalse = name.Contains("t");
            trueOrFalse = name.EndsWith("e");

            int length = name.Length;

            name = name.ToUpper(); // Or lowercase with name.ToLower();

            string name2 = "Catherine";
            name2 = "Sam";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Catherine");


            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}