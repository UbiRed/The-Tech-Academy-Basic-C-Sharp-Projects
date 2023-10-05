using System;

namespace YoBFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user age
            Console.Write("Please enter your age: ");

            try
            {
                // Read user's input as string
                string input = Console.ReadLine();

                // Parse input into an integer
                int age = int.Parse(input);

                // Check if age is zero or negative
                if (age <= 0)
                {
                    // Display error message for invalid input
                    Console.WriteLine("Please enter a valid positive age.");
                }
                else
                {
                    // Calculate birth year, subtracting age from current year
                    int birthYear = DateTime.Now.Year - age;

                    // Display birth year
                    Console.WriteLine($"You were born in the year {birthYear}.");
                }
            }
            catch (FormatException)
            {
                // Handle the exception for invalid input
                Console.WriteLine("Please enter a whole number with no decimals for your age.");
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
