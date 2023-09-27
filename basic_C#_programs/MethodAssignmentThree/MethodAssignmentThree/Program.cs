using System;

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call the method in the class, passing in two numbers
        mathOps.PerformOperation(10, 5);

        // Call the method in the class, specifying the parameters by name
        mathOps.PerformOperation(number1: 20, number2: 7);

        Console.ReadLine();
    }
}
