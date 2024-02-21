using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// String functions returns data of a user-given string
    /// </summary>
    internal class StringFunctions
    {
        /// <summary>
        /// The start method loops through and calls all supportive methods
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Welcome to the String function!\n");
            // Loops until the user chooses something else than y
            string loopChoice;
            do
            {
                // Calls the helper methods
                StringLength();
                PredictMyDay();
                // Checks if the user wants the method to keep looping
                loopChoice = RunAgain();
            }
            while(loopChoice == "y");
        }
        /// <summary>
        /// Prints the string length and the string itself in upper case
        /// </summary>
        private static void StringLength()
        {
            Console.WriteLine("What string would you like to count the legnth of?\n" +
                    "Please enter the string and press enter");
            string choice = Console.ReadLine();
            int length = choice.Length;
            Console.WriteLine($"The string {choice.ToUpper()} has a length of: {length}");
        }
        /// <summary>
        /// Asks the user if the application should loop another round
        /// </summary>
        /// <returns>The choice of the user</returns>
        private static string RunAgain()
        {
            Console.WriteLine("\nContinue with another round? (y/n):");
            string loopChoice = Console.ReadLine();
            return loopChoice;
        }
        /// <summary>
        /// Writes out a humorous text depending on user choice
        /// </summary>
        private static void PredictMyDay()
        {
            Console.WriteLine("\nNow time for some humor, please enter a number between 1 and 7:\n");
            string numberChoice = Console.ReadLine();
            List<string> textReturn = new List<string>()
            {
                "Monday, the day when even coffee needs coffee.",
                "Tuesday, because even Monday needs to feel god about itself.",
                "Wednesday, the day that taunts you with its middle-of-the-weekness.",
                "Thursday, where you're so close to Friday, yet so far.",
                "Friday, the day when productivity takes a backseat to weekend plans.",
                "Saturday, the day you finally remember what sleep feels like.",
                "Sunday, where productivity means deciding what to binge-watch next."
            };
            // Switch case to find the corresponding text to user-given number
            switch(numberChoice)
            {
                default:
                    Console.WriteLine("Try a number between 1 and 7");
                    break;
                case "1":
                    Console.WriteLine(textReturn[0]);
                    break;
                case "2":
                    Console.WriteLine(textReturn[1]);
                    break;
                case "3":
                    Console.WriteLine(textReturn[2]);
                    break;
                case "4":
                    Console.WriteLine(textReturn[3]);
                    break;
                case "5":
                    Console.WriteLine(textReturn[4]);
                    break;
                case "6":
                    Console.WriteLine(textReturn[5]);
                    break;
                case "7":
                    Console.WriteLine(textReturn[6]);
                    break;
            }
        }
    }
}
