using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// A class that calculates values according to user-given numbers
    /// </summary>
    internal class MathWork
    {
        /// <summary>
        /// Triggers the calculation workflow
        /// </summary>
        public void Start()
        {
            Calculate();
        }
        /// <summary>
        /// Calculates and prints numbers after reading user input
        /// </summary>
        private void Calculate()
        {
            // Loop keeps running until the user chooses to exit the calculation
            bool continueLoop;
            do 
            {
                // Collects user input
                Console.WriteLine("Enter a starting integer number");
                int startInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a ending integer number");
                int endInput = Convert.ToInt32(Console.ReadLine());

                // Make sure we pass the lowest number to the correct place in our methods
                int startInt = Math.Min(startInput, endInput);
                int endInt = Math.Max(startInput, endInput);

                // Calculates sum, and trigger our other methods
                int sum = SumNumbers(startInt, endInt);
                Console.WriteLine($"The sum is: {sum}\n");
                PrintEvenNumbers(startInt, endInt);
                PrintOddNumbers(startInt, endInt);
                CalculateSquareRoots(startInt, endInt);

                // Ask if the user wants to repeat the loop
                continueLoop = ExitCalculation();
            } 
            while 
            (continueLoop == true);
        }
        /// <summary>
        /// Calculates square roots of all integers in a range
        /// </summary>
        /// <param name="num1">The lower end of the range</param>
        /// <param name="num2">The higher end of the range</param>
        private void CalculateSquareRoots(int num1, int num2)
        {
            // We loop through the whole range
            for (int i = num1; i <= num2; i++)
            {
                string rowSum = "";
                // For the remaining integers in the range
                for (int j = i; j <= num2; j++)
                {
                    // Calculate the square root and round the result
                    rowSum += Math.Round(Math.Sqrt(j),2) + " ";
                }
                // Print all combinations of the current integer and the rest in the range
                Console.WriteLine($"Square roots ({i} to {num2}) is: {rowSum}");
            }
        }
        /// <summary>
        /// Asks the user if they want to exit the application
        /// </summary>
        /// <returns>A bool, representing if the user want the loop to continue or not</returns>
        private bool ExitCalculation()
        {
            Console.WriteLine("\nContinue with another round? (y/n):");
            string loopChoice = Console.ReadLine();
            return loopChoice == "y";
        }
        /// <summary>
        /// Prints all even numbers in the range
        /// </summary>
        /// <param name="number1">The lower end of the range</param>
        /// <param name="number2">The higher end of the range</param>
        private void PrintEvenNumbers(int number1, int number2)
        {
            List<string> output = new List<string>();
            for (int i = number1; i <= number2; i++)
            {
                // If number is even
                if (i % 2 == 0)
                {
                    output.Add(i.ToString());
                }
            }
            Console.WriteLine($"The even numbers in the range are: {String.Join(",",output)}\n");
        }
        /// <summary>
        /// Prints all odd numbers in the range
        /// </summary>
        /// <param name="number1">The lower end of the range</param>
        /// <param name="number2">The higher end of the range</param>
        private void PrintOddNumbers(int number1, int number2)
        {
            // We start by creating a list to use as output, and then loop through the range
            List<string> output = new List<string>();
            for (int i = number1; i <= number2; i++)
            {
                // If the number is odd
                if (i % 2 != 0)
                {
                    output.Add(i.ToString());
                }
            }
            Console.WriteLine($"The odd numbers in the range are: {String.Join(",", output)}\n");
        }
        /// <summary>
        /// Sums all integer numbers of a range 
        /// </summary>
        /// <param name="start">The lower end of the range</param>
        /// <param name="end">The higher end of the range</param>
        /// <returns></returns>
        private int SumNumbers(int start, int end)
        {
            int sum = 0;
            // Loop through the range, and sum each integer
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
