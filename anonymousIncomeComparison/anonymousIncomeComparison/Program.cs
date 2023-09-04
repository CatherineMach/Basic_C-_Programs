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

        int salary1 = hourly * hours * 52;
        Console.WriteLine("Annual salary of Person 1: " + salary);
        Console.WriteLine("Annual salary of Person 2");
        int salary11 = Convert.ToInt32(Console.ReadLine());

        int salary2 = hourly * hours * 52;
        Console.WriteLine("Annual salary of Person 2: " + salary);
        Console.WriteLine("Does Person 1 make more money than Person 2?");




        bool moreMoney = salary11 > salary2;
        Console.WriteLine(moreMoney);



        Console.ReadLine();
    }

}