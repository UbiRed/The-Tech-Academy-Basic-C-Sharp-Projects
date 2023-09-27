using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        try
        {
            // Ask the user for a number to divide each number in the list by
            Console.Write("Enter a number to divide each number in the list by: ");
            string userInput = Console.ReadLine();

            int divisor;

            // Check if the user input is a valid integer
            if (int.TryParse(userInput, out divisor))
            {
                // Loop through the list and divide each number by the user's input
                Console.WriteLine("Results:");
                foreach (int number in numbers)
                {
                    try
                    {
                        int result = number / divisor;
                        Console.WriteLine($"{number} / {divisor} = {result}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine($"{number} / {divisor} = Cannot divide by zero");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        // Message to indicate program execution outside the try/catch block
        Console.WriteLine("Program has continued successfully.");

        // Wait for user input before exiting
        Console.ReadLine();
    }
}
