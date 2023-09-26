using System;
using System.Collections.Generic; // Import the System.Collections.Generic namespace for List

class Program
{
    static void Main()
    {

        // Declare and initialize an array of strings
        string[] stringArray = { "Apple", "Banana", "Cherry", "Date" };

        // Ask the user to select an index
        Console.Write("Select an index (0-4) to display a fruit from the array: ");
        if (int.TryParse(Console.ReadLine(), out int stringIndex) && stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            // Display the string at the selected index
            Console.WriteLine("Selected Fruit: " + stringArray[stringIndex]);
        }
        else
        {
            // Display a message for an invalid index
            Console.WriteLine("Invalid index. Please select an index between 0 and 4.");
        }

        // Declare and initialize an array of integers
        int[] intArray = { 10, 20, 30, 40, 50 };

        // Ask the user to select an index
        Console.Write("Select an index (0-4) to display an integer from the array: ");
        if (int.TryParse(Console.ReadLine(), out int intIndex) && intIndex >= 0 && intIndex < intArray.Length)
        {
            // Display the integer at the selected index
            Console.WriteLine("Selected Integer: " + intArray[intIndex]);
        }
        else
        {
            // Display a message for an invalid index
            Console.WriteLine("Invalid index. Please select an index between 0 and 4.");
        }

        // Create a list of strings
        List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Orange" };

        // Ask the user to select an index
        Console.Write("Select an index (0-4) to display a color from the list: ");
        if (int.TryParse(Console.ReadLine(), out int listIndex) && listIndex >= 0 && listIndex < stringList.Count)
        {
            // Display the content at the selected index
            Console.WriteLine("Selected Color: " + stringList[listIndex]);
        }
        else
        {
            // Display a message for an invalid index
            Console.WriteLine("Invalid index. Please select an index between 0 and 4.");
        }

        Console.ReadLine();

    }
}
