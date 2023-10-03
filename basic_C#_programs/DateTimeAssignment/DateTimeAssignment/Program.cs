using System;

namespace DateTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print date and time
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {currentDateTime}");

            // Ask user for a number
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Attempt to parse the user's input into an integer
            if (int.TryParse(userInput, out int hoursToAdd))
            {
                // Calculate the future date and time
                DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);
                Console.WriteLine($"In {hoursToAdd} hours, it will be: {futureDateTime}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
