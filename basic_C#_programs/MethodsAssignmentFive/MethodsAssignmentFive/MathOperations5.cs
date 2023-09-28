using System;

public class MathUtility
{
    // Create a void method that divides the data passed to it by 2
    public void DivideByTwo(int number)
    {
        // Output the result of the division
        Console.WriteLine($"Result of division: {number / 2}");
    }

    // Create a method with output parameters
    public void MultiplyByTwo(int input, out int result)
    {
        // Multiply the input by 5 and assign it to the result parameter
        result = input * 5;
    }

    // Overload the MultiplyByTwo method to accept a double input
    public void MultiplyByTwo(double input, out double result)
    {
        // Multiply the input by 2 and assign it to the result parameter
        result = input * 2;
    }
}