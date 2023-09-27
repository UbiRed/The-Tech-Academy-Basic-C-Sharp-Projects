using System;

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call the first method with an integer
        int result1 = mathOps.PerformOperation(10);
        Console.WriteLine($"Result of the first method: {result1}");

        // Call the second method with a decimal
        decimal decimalValue = 7.5M;
        int result2 = mathOps.PerformOperation(decimalValue);
        Console.WriteLine($"Result of the second method: {result2}");

        // Call the third method with a string that equates to an integer
        string inputString = "15";
        int result3 = mathOps.PerformOperation(inputString);
        Console.WriteLine($"Result of the third method: {result3}");

        Console.ReadLine(); // Wait for user input to exit
    }
}
