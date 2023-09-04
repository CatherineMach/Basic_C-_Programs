using System;
using System.Xml.Schema;

class Program
{
    static void Main()
    {   //title + weight of package
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine("Please enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {

            //the package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());



            //the package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());



            //the package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int totalDimensions = length + height + width;

            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
            int totalCost = totalDimensions * weight / 100;
            }
            Console.WriteLine("$" + totalCost);

            Console.ReadLine();
        }
    }

}