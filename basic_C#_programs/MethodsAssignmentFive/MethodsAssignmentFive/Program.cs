using System;


class Program
{
    static void Main()
    {
        // Instantiate the MathUtility class
        MathUtility mathUtil = new MathUtility();

        Console.Write("Enter a number: ");
        int userInput = int.Parse(Console.ReadLine());

        // Call the DivideByTwo method and display the result
        mathUtil.DivideByTwo(userInput);

        // Call the MultiplyByTwo method with an output parameter
        int outputValue;
        mathUtil.MultiplyByTwo(userInput, out outputValue);
        Console.WriteLine($"Result of multiplication: {outputValue}");

        // Call the overloaded MultiplyByTwo method with a double input
        double userInputDouble = userInput;
        double outputValueDouble;
        mathUtil.MultiplyByTwo(userInputDouble, out outputValueDouble);
        Console.WriteLine($"Result of multiplication (double): {outputValueDouble}");

        // Access the MaxValue and AppName from the Constants class
        Console.WriteLine($"Max Value: {Constants.MaxValue}");
        Console.WriteLine($"App Name: {Constants.AppName}");

        Console.ReadLine(); // Wait for user input to exit
    }
}
