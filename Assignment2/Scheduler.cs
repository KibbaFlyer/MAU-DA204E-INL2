using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /// <summary>
    /// The Scheduler class shows week numbers for a schedule set by the user
    /// </summary>
    internal class Scheduler
    {
        /// <summary>
        /// The start function - which triggers all necessary methods
        /// </summary>
        public void Start()
        {
            // We start a loop that the user can exit with a 0
            string continueLoop;
            // Calling the method to gather user input
            var input = GetInput();
            do
            {
                // This method asks the user for alternatives
                continueLoop = Options();
                // We then calculate the schedule based on inputs
                var schedule = CalculateSchedule(input.Item1, input.Item2, input.Item3, input.Item4);
                // Depending on the choice by the user - print different information
                switch (continueLoop)
                {
                    default:
                        break;
                    case "1":
                        Console.WriteLine(schedule.Item1);
                        break;
                    case "2":
                        Console.WriteLine(schedule.Item2);
                        break;
                    case "3":
                        input = GetInput();
                        break;
                }
            }
            while (continueLoop != "0");
        }
        /// <summary>
        /// Asks the user for options
        /// </summary>
        /// <returns>The choice of the user: 0, 1, 2, or 3</returns>
        private string Options()
        {
            Console.WriteLine(
                "\n" +
                "1 Show a list of the weekends to work\n" +
                "2 Show a list of the nights to work\n" +
                "3 Enter new start and interval values\n" +
                "0 Exit");
            Console.Write("Your choice: ");
            string loopChoice = Console.ReadLine();
            return loopChoice;
        }
        /// <summary>
        /// Retrieves input by the user
        /// </summary>
        /// <returns>Four ints containing the schedule information by the user</returns>
        private (int, int, int, int) GetInput()
        {
            Console.Clear();
            Console.Write("Which week do you start working weekends: ");
            int startWeekend = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the weekend work interval you have: ");
            int intervalWorkWeek = Convert.ToInt32(Console.ReadLine());
            Console.Write("Which week do you start working nights: ");
            int startNights = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the night shift work interval you have: ");
            int intervalNightShifts = Convert.ToInt32(Console.ReadLine());
            return (startWeekend, intervalWorkWeek, startNights, intervalNightShifts);
        }
        /// <summary>
        /// Calculates the schedule according to user data
        /// </summary>
        /// <param name="startWeekend">The first weekend the user works</param>
        /// <param name="intervalWorkWeek">The interval the user works weekends</param>
        /// <param name="startNights">The first night shift the user works</param>
        /// <param name="intervalNightShifts">The interval the user works night shifts</param>
        /// <returns>Strings containing the schedule, formatted for console output</returns>
        private (string, string) CalculateSchedule(int startWeekend, int intervalWorkWeek, int startNights, int intervalNightShifts)
        {
            // We initialize the Lists where we will add strings
            List<string> workWeekShifts = new List<string>();
            List<string> nightShiftWeeks = new List<string>();
            // Week counter to format the console output
            int weekCounter = 0;
            // Starts a loop at the starting weekend and loops it for all 52 weeks in user-given intervals
            for (int i = startWeekend; i <= 52; i+=intervalWorkWeek)
            {
                weekCounter++;
                // Makes sure there are 5 columns per row
                if (weekCounter % 5 == 0 && weekCounter != 0)
                {
                    workWeekShifts.Add($"Week {i}\n");
                }
                else
                {
                    workWeekShifts.Add($"Week {i}\t");
                }
            }
            weekCounter = 0;
            // Starts a loop at the starting night shift and loops it for all 52 night-shifts in user-given intervals
            for (int i = startNights; i <= 52; i+=intervalNightShifts)
            {
                weekCounter++;
                if (weekCounter % 5 == 0 && weekCounter != 0)
                {
                    nightShiftWeeks.Add($"Week {i}\n");
                }
                else
                {
                    nightShiftWeeks.Add($"Week {i}\t");
                }
            }
            return (String.Join("",workWeekShifts), String.Join("",nightShiftWeeks));

        }
    }
}
