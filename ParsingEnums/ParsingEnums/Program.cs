using System;


namespace ParsingEnums
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week.");
            string userinput = Console.ReadLine();
            try
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userinput);
                Console.WriteLine("You chose this day of the week " + day);
            }
            catch 
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

        }
    }
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}