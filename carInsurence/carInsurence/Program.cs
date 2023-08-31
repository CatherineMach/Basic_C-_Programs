using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        int age1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI");
        bool help = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("How many speeding tickets do you have?");
        int ticket = Convert.ToInt32(Console.ReadLine());

        int age = 24;
        bool hadDUI = false;
        bool tickets = false;

        bool insurence = (age >= 15 && hadDUI && tickets);
        Console.WriteLine(insurence);
        Console.ReadLine();

    }

}