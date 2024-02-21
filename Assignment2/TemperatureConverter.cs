using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment2
{
    /// <summary>
    /// Class to write out temperature scales of Celsius and Fahrenheit
    /// </summary>
    internal class TemperatureConverter
    {
        /// <summary>
        /// Start method, writes a welcome message, then loops as it's listening and waits for input exists at input "0" from user
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Welcome to the TemperatureConverter!\n" +
                "What would you like to see?\n");
            string choice = "";
            // Loops as long as the user has not chosen option 0
            do
            {
                Console.WriteLine("Enter 0 to close the application, 1 for Celsius and 2 for Fahrenheit");
                Console.Write("Your choice: ");
                choice = Console.ReadLine();
                string output = "";
                // If the user chooses to see Celsius
                if (choice == "1")
                {
                    // For each tenth number in the range 0-212, transform it to celsius
                    for (double i = 0; i <= 212; i+=10)
                    {
                        if (i % 30 == 0)
                        {
                            output += $"\n{i,7} F = {ConvertToCelsius(i),6} C\t";
                        }
                        else
                        {
                            output += $"{i, 7} F = {ConvertToCelsius(i),6} C\t";
                        }
                    }
                    output += "\n";
                    Console.Write(output);
                }
                else if (choice == "2")
                {
                    // For each fifth number in the range 0-100, transform it to farenheit
                    for (double i = 0; i <= 100; i+=5)
                    {
                        if (i % 15 == 0)
                        {
                            output += $"\n{i,7} C = {ConvertToFahrenheit(i),4} F\t";
                        }
                        else
                        {
                            output += $"{i,7} C = {ConvertToFahrenheit(i),4} F\t";
                        }
                    }
                    output += "\n";
                    Console.WriteLine(output);
                }
                // If the user chooses something else than 0,1,2
                else if (choice != "0")
                {
                    Console.Write("Enter valid choice...");
                }
            }
            while (choice != "0");
        }
        /// <summary>
        /// Converts a value to Celsius
        /// </summary>
        /// <param name="value">Value to be converted, as double</param>
        /// <returns>Celsius temperature as double</returns>
        private static double ConvertToCelsius(double value)
        {
            return Math.Round((5.0 / 9.0) * (value - 32.0), 2 );
        }
        /// <summary>
        /// Converts a value to Fahrenheit
        /// </summary>
        /// <param name="value">Value to be converted, as double</param>
        /// <returns>Fahrenheit temperature as double</returns>
        private static double ConvertToFahrenheit(double value)
        {
            return Math.Round(9.0 / 5.0 * value + 32.0, 2 );
        }
    }
}
