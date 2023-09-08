using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        // Array Fundementals ^
        // Lists v

        List<int> intList = new List<int>();
        intList.Add(4); //Or intList.Add("Hello");
        intList.Add(10);
        intList.Remove(10);

        byte[] byteArray = new byte[5000];


        Console.WriteLine(intList[0]);
        Console.ReadLine();
    }
}