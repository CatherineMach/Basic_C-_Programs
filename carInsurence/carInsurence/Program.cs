using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Have you ever had a DUI");
        bool hadDUI = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("How many speeding tickets do you have?");
        int tickets = Convert.ToInt32(Console.ReadLine());



        bool insurence = (age >= 15 && hadDUI && tickets);
        Console.WriteLine(insurence);
        Console.ReadLine();

    }

}