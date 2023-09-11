using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO.Pipes;

class Program
{

    static void Main(string[] args)
    {
        //start of assignment 1
        string[] Colors = new string[] { "red", "orange", "yellow", "green", "blue" };
        Console.WriteLine("input some text");
        string userText = Console.ReadLine();
        for (int i = 0; i < Colors.Length; i++)
        {
            Colors[i] = Colors[i] + userText;
        }
        for (int i = 0; i < Colors.Length; i++)
        {
            Console.WriteLine(Colors[i]);
        }
        Console.ReadLine();


        //end of assignment 1

        //start of assignment 2
        while (true)
        {
            Console.WriteLine("Infinite Loop:D (hit enter)");
            Console.ReadLine();
        }
        
        
    }

}