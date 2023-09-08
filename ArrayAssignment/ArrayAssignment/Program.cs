using System;
using System.Collections.Generic;


class Program
{

    static void Main()
    {
        string[] stringList = new string[] { "red", "blue", "green", "yellow" };
        Console.WriteLine("Choose an index between 0 and 3");
        int index1 = Convert.ToInt32(Console.ReadLine());

        if (index1 < 0 || index1 >= stringList.Length)
        {
            Console.WriteLine("That index doesn't exist.");
        }
        else
        {
            Console.WriteLine(stringList[index1]);
        }


        int[] intList = new int[] { 1, 2, 3, 4, };
        Console.WriteLine("Choose an index between 0 and 3");
        int index3 = Convert.ToInt32(Console.ReadLine());

        if (index3 < 0 || index3 >= intList.Length)
        {
            Console.WriteLine("That index doesn't exist.");
        }
        else
        {
            Console.WriteLine(intList[index3]);
        }


        List<string> stringList2 = new List<string>()
        {
            "square", "rectangle", "triangle", "circle"
        };
        Console.WriteLine("Choose an index between 0 and 3");
        int index2 = Convert.ToInt32(Console.ReadLine());
        if (index2 < 0 || index2 >= stringList2.Count)
        {
            Console.WriteLine("That index doesn't exist.");
        }
        else
        {
            Console.WriteLine(stringList2[index2]);
        }



        Console.ReadLine();
    }
}