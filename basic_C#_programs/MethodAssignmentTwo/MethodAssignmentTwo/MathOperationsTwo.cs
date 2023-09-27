using System;

public class MathOperations
{
    // Method 1: Takes an integer, adds 5 to it, and results as an integer
    public int PerformOperation(int number)
    {
        return number + 5;
    }

    // Method 2: Takes a decimal, multiplies it by 2, and results as an integer
    public int PerformOperation(decimal number)
    {
        return (int)(number * 2);
    }

    // Method 3: Takes a string, converts it to an integer, subtracts 3, and results as an integer
    public int PerformOperation(string input)
    {
        if (int.TryParse(input, out int number))
        {
            return number - 3;
        }
        else
        {
            Console.WriteLine("Invalid input. Couldn't convert to an integer.");
            return 0; // Default value for invalid input
        }
    }
}