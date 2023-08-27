using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        Console.WriteLine("15");
        Console.WriteLine("Hours worked per week?");
        Console.WriteLine("40");
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        Console.WriteLine("20");
        Console.WriteLine("Hours worked per week?");
        Console.WriteLine("40");
        Console.WriteLine("Annual salary of Person 1");
        Console.WriteLine("31,200");
        Console.WriteLine("Annual salary of Person 2");
        Console.WriteLine("41,600");
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        
        int Person1 = 31200;
        int Person2 = 41600;

        bool moreMoney = Person1 > Person2;
        Console.WriteLine(moreMoney);



        Console.ReadLine();
    }

}