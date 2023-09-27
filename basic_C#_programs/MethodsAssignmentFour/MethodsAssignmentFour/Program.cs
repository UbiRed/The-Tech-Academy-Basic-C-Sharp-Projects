using System;

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOps = new MathOperations();

        Console.WriteLine("Enter the first number:");
        int input1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number (press Enter to skip):");
        string input2String = Console.ReadLine();

        int input2;
        bool parseSuccess = int.TryParse(input2String, out input2);

        // Call the method in the class, passing in the one or two numbers entered
        if (parseSuccess)
        {
            int result = mathOps.PerformOperation(input1, input2);
            Console.WriteLine($"Result of the operation: {result}");
        }
        else
        {
            int result = mathOps.PerformOperation(input1);
            Console.WriteLine($"Result of the operation: {result} (using default value for the second number)");
        }

        Console.ReadLine(); // Wait for user input to exit
    }
}
