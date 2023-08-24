using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        //The title to the daily report
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");


        //asking what your name is
        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();
        Console.WriteLine("Your name is: " + yourName);

        //asking what course you're on
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("You're on the course: " +  course);

        //the page number you're on
        Console.WriteLine("What page number of the course?");
        int pageNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You're on page: " + pageNumber);

        //need any help?
        Console.WriteLine("Do you need help with anything? Please answer with true or false");
        bool help = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("You need help " + help);

        //positive experiences!!
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
        string positiveExperiences = Console.ReadLine();
        Console.WriteLine("Thank you for the response!");

        //any feedback?
        Console.WriteLine("Is there any other feedback you'd like to provide? Please give specifics");
        string feedback = Console.ReadLine();
        Console.WriteLine("Thank you for the response!");

        //how many hours did you study?
        Console.WriteLine("How many hours did you study today?");
        int hours = Convert.ToInt32(Console.ReadLine());

        //ending
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }

}