using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        Console.WriteLine("24");
        Console.WriteLine("Have you ever had a DUI");
        Console.WriteLine("No");
        Console.WriteLine("How many speeding tickets do you have?");
        Console.WriteLine("Zero");

        int age = 24;
        bool hadDUI = false;
        bool tickets = false;

        bool insurence = (age >= 15 && hadDUI && tickets);
        Console.WriteLine(insurence);
        Console.ReadLine();

    }

}