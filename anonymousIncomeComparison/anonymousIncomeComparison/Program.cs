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

        int salary1 = Convert.ToInt32(hourly) * Convert.ToInt32(hours) * 52;

        Console.WriteLine("Person 2");

        Console.WriteLine("Hourly Rate?");
        int hourly2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hours worked per week?");
        int hours2 = Convert.ToInt32(Console.ReadLine());

        int salary2 = Convert.ToInt32(hourly2) * Convert.ToInt32(hours2) * 52;

        Console.WriteLine("Annual salary of Person 1");
        Console.WriteLine(salary1);

        
        Console.WriteLine("Annual salary of Person 2");
        Console.WriteLine(salary2);

        Console.WriteLine("Does Person 1 make more money than Person 2?");




        bool moreMoney = salary1 > salary2;
        Console.WriteLine(moreMoney);



        Console.ReadLine();
    }

}