using System;

class Program
{
    static void Main()
    {
        double number;

        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read user input as a string
        string userInput = Console.ReadLine();

        // Attempt to parse the input as a double
        if (double.TryParse(userInput, out number))
        {
            // Multiply the input by 50
            double result1 = number * 50;

            // Print the result to the console
            Console.WriteLine("1. Result (Multiply by 50): " + result1);
        }
        else
        {
            // Invalid input
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read user input as a string
        userInput = Console.ReadLine();

        // Attempt to parse the input as a double
        if (double.TryParse(userInput, out number))
        {
            // Add 25 to the input
            double result2 = number + 25;

            // Print the result to the console
            Console.WriteLine("2. Result (Add 25): " + result2);
        }
        else
        {
            // Invalid input
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read user input as a string
        userInput = Console.ReadLine();

        // Attempt to parse the input as a double
        if (double.TryParse(userInput, out number))
        {
            // Divide the input by 12.5
            double result3 = number / 12.5;

            // Print the result to the console
            Console.WriteLine("3. Result (Divide by 12.5): " + result3);
        }
        else
        {
            // Invalid input
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read user input as a string
        userInput = Console.ReadLine();

        // Attempt to parse the input as a double
        if (double.TryParse(userInput, out number))
        {
            // Check if the input is greater than 50
            bool isGreaterThan50 = number > 50;

            // Print the true/false result
            Console.WriteLine("4. Is greater than 50: " + isGreaterThan50);
        }
        else
        {
            // Invalid input
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        // Prompt user for input
        Console.Write("Enter a number: ");

        // Read user input as a string
        userInput = Console.ReadLine();

        // Attempt to parse the input as a double
        if (double.TryParse(userInput, out number))
        {
            // Calculate the remainder when dividing by 7
            double remainder = number % 7;

            // Print the remainder to the console
            Console.WriteLine("5. Remainder when divided by 7: " + remainder);
        }
        else
        {
            // Invalid input
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        Console.ReadLine();
    }
}
