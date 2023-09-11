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
            x++;
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
        if (!shapes.Contains(userText2))
        {
            Console.WriteLine("That shape isn't on the list");
        }
        else
        {
            for (int i = 0;i < shapes.Count;i++)
            {
                if (shapes[i] == userText2)
                {
                    Console.WriteLine(shapes[i] + " at index: " + i);
                    break;
                }
            }
        }
        //end of assignment 4
        Console.ReadLine();
        //start of assignment 5
        List<string> flower = new List<string>()
        {
            "rose", "rose", "sunflower", "bluebell"
        };
        Console.WriteLine("select a flower to search in the list");
        string userText3 = Console.ReadLine();
        if (!flower.Contains(userText3))
        {
            Console.WriteLine("That shape isn't on the list");
        }
        else
        {
            for (int i = 0; i < flower.Count; i++)
            {
                if (flower[i] == userText3)
                {
                    Console.WriteLine(flower[i] + " at index: " + i);

                }
            }
        }
        Console.ReadLine();
        //end of assignment 5

        //start of assignment 6
        char[] letter = { 'A', 'A', 'C', 'C', 'A' };
        int vowel = 0, alphabet = 0;
        foreach (char l in letter)
        {
            if (l == 'A')
                vowel++;
            else if (l == 'C')
                alphabet++;
        }
        Console.WriteLine("Number of vowels = {0}", vowel);
        Console.WriteLine("Number of alphabetical words = {0}", alphabet);
        //end of assignment 6
    }
   
}