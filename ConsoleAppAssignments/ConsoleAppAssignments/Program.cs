using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


class Program
{

    static void Main(string[] args)
    {
        //start of assignment 1
        string[] Colors = new string[] { "red", "orange", "yellow", "green", "blue" };
        Console.WriteLine("input some text");
        string userText = Console.ReadLine();

        do
        {
            switch (Colors)
            {
                case 0:
                    Console.WriteLine(Colors[0] + userText);
                    break;

                case 1:
                    Console.WriteLine(Colors[1] + userText);
                    break;

                case 2:
                    Console.WriteLine(Colors[2] + userText);
                    break;

                case 3:
                    Console.WriteLine(Colors[3] + userText);
                    break;

                case 4:
                    Console.WriteLine(Colors[4] + userText);
                    break;

                default:
                    Console.WriteLine(Colors + userText);
                    break;
            }
            Console.ReadLine();
        }
        while (true);


        
        
        
    }

}