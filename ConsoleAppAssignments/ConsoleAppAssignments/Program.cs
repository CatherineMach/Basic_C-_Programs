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
        int x = 0;
        while (x < 3)
        {
            Console.WriteLine(x);

        }
        //end of assignment 2
        //start of assignment 3
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(i);
        }
        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine(i);
        }
        //end of assignment 3
        //start of assignment 4
        List<string> shapes = new List<string>()
        {
            "square", "rectangle", "oval", "circle", "triangle"
        };
        Console.WriteLine("write down a shape");
        string userText2 = Console.ReadLine();
        if (userText2 = 0 && userText2 >= shapes.Count)
        {
            Console.WriteLine("That shape isnt in the list");
        }
        else
        {
            Console.WriteLine(shapes[userText2]);
        }
    }

}