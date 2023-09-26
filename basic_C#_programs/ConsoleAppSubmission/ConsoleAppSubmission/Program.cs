using System;

class Program
{
    static void Main()
    {
        // Display a welcome message
        Console.WriteLine("Boolean Comparison: While and Do-While Statements");
        Console.WriteLine("~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~");

        // Initialize variables for boolean comparisons
        int number = 10;
        int target = 5;

        // Example 1: Boolean Comparison using a While Statement

        Console.WriteLine("\nWhile Statement");
        Console.WriteLine("---------------------");
        while (number > target)
        {
            Console.WriteLine($"{number} is greater than {target}");
            number--;
        }


        // Example 2: Boolean Comparison using a Do-While Statement

        Console.WriteLine("\nDo-While Statement");
        Console.WriteLine("-----------------------");
        // Reset the variables
        number = 10;
        target = 20;
        do
        {
            Console.WriteLine($"{number} is less than {target}");
            number++;
        } while (number < target);

        // End
        Console.WriteLine("\nProgram completed. Press Enter to exit.");
        Console.ReadLine();
    }
}
