using System;

class Program
{
    static void Main()
    {
        // Ask user for an input
        Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int userNumber))
        {
            // Instanciate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call each method
            int squaredNumber = mathOps.Square(userNumber);
            int doubledNumber = mathOps.Double(userNumber);
            int numberPlusTen = mathOps.AddTen(userNumber);

            // Display the results
            Console.WriteLine($"Square: {squaredNumber}");
            Console.WriteLine($"Double: {doubledNumber}");
            Console.WriteLine($"Add 10: {numberPlusTen}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.ReadLine(); 
    }
}
