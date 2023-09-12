using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>{ 32, 72, 98, 48, 50 };

        try
        {
            Console.WriteLine("Write a number to divide some numbers with:)");
            int userNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i] + " divided by " + userNum + " equals " + numList[i] / userNum);
            }


        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally 
        { 
            Console.WriteLine("Program has emerged from the try/catch block");
            Console.ReadLine();
        }



    }
    
}