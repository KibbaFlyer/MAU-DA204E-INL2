// See https://aka.ms/new-console-template for more information
using Assignment2;

class Program
{
    /// <summary>
    /// Main method that triggers in program startup
    /// Here we run each sub-application by itself, calling the ContinueToNext between them.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        // First welcoming message
        Console.Clear();
        Console.Title = "Assignement 2 <By: Kristoffer Flygare>";
        Console.WriteLine("Welcome to Assignment 2 by Kristoffer Flygare");
        // We run the temperature converter application
        ContinueToNext("TemperatureConverter");
        TemperatureConverter temperatureConverter = new TemperatureConverter();
        temperatureConverter.Start();
        // We run the string functions application
        ContinueToNext("StringFunctions");
        StringFunctions stringFunctions = new StringFunctions();
        stringFunctions.Start();
        // We run the math work application
        ContinueToNext("MathWorks");
        MathWork mathWork = new MathWork();
        mathWork.Start();
        // We run the scheduler application
        ContinueToNext("Scheduler");
        Scheduler scheduler = new Scheduler();
        scheduler.Start();
    }
    /// <summary>
    /// This method is run between each part of the application, in order to rename the console and clear it.
    /// It needs to be static so that it is accessible without being tied to a instance
    /// </summary>
    /// <param name="title">Title of the next part of the application</param>
    private static void ContinueToNext(string title)
    {
        Console.WriteLine("\nPress enter to continue to next part of the application\n");
        Console.ReadLine();
        Console.Clear();
        Console.Title = title;
        Console.WriteLine($" - - - - {title} - - - -");
    }
}

