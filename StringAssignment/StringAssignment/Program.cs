using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string hello = "Hello There!";
        hello = hello.ToUpper();

        string quote = "You must be the change you wish to see in the world. -Mahatma Gandhi";
        string fileName = @"C:\Users\Catherine";
        string name = "Catherine";

        StringBuilder sb = new StringBuilder();
        sb.Append("Hello, My name is Catherine.\n This is me writing a paragraph for the String Assignment \n I've been enjoying this course so far and can really see myself going down a career path using C+");
        Console.WriteLine(sb.ToString());



        Console.WriteLine(hello);
        Console.WriteLine(quote);
        Console.WriteLine(fileName);
        Console.WriteLine(name);
        Console.ReadLine();
    }

}