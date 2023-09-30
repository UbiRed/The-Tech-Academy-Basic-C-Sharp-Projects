using System;

// Define a struct, Number
struct Number
{
    // Property Amount of data type decimal
    public decimal Amount { get; set; }
}

class Program
{
    static void Main()
    {
        // Create an object of data type Number
        Number number = new Number();

        // Assign a number to it
        number.Amount = 123.45M;

        // Print the amount to the console
        Console.WriteLine($"The amount is: {number.Amount}");
        Console.ReadLine();
    }
}
