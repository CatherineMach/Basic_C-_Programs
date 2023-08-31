using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        int hourly = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        int hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        int hourly2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        int hours2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Annual salary of Person 1");
        int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Annual salary of Person 2");
        int salary2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        
        int Person1 = 31200;
        int Person2 = 41600;

        bool moreMoney = Person1 > Person2;
        Console.WriteLine(moreMoney);



        Console.ReadLine();
    }

}