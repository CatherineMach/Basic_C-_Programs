using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI");
        bool help = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("How many speeding tickets do you have?");
        int ticket = Convert.ToInt32(Console.ReadLine());

        bool help = false;
        int tickets = 3;

        bool insurence = (age >= 15 && help && tickets);
        Console.WriteLine(insurence);
        Console.ReadLine();

    }

}