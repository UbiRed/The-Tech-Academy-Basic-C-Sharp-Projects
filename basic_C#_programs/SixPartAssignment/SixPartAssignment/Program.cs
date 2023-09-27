using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] stringArray = new string[5];

        // Ask the user to input some text
        Console.Write("Enter some text: ");
        string userInput = Console.ReadLine();

        // Loop to iterate through the array and append user's text input
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] = "Element " + (i + 1) + ": " + userInput; // Appending user's input to each element
        }

        // Loop to print each string in the array
        Console.WriteLine("Updated Array Elements:");
        Console.WriteLine("-------------------------------");
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.WriteLine(stringArray[i]);
        }

        Console.WriteLine("-------------------------------");

        // Introduce an infinite loop
        while (true)
        {
            Console.WriteLine("This is an infinite loop. Enter 'exit' to exit the program.");
            string exitInput = Console.ReadLine();

            // Check if the user wants to exit the infinite loop
            if (exitInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                // Exit the loop if the user enters 'exit'
                break;
            }
        }

        // Introduce a loop using the "<" operator
        Console.WriteLine("\nLoop using the '<' operator:");
        Console.WriteLine("-------------------------------");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }

        // Introduce a loop using the "<=" operator
        Console.WriteLine("\nLoop using the '<=' operator:");
        Console.WriteLine("-------------------------------");
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }

        Console.WriteLine("-------------------------------");


        // Introduce a list of unique strings
        List<string> uniqueStrings = new List<string> { "Honda", "Toyota", "Acura", "Scion", "Mazda" };

        // Print the entire list for the user to see
        Console.WriteLine("List of japanese car manufacturers:");
        foreach (string item in uniqueStrings)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------------------------------");


        // Ask the user to input text to search for in the list
        Console.Write("Enter a japanese car manufacturer from the list: ");
        string searchText = Console.ReadLine();

        bool found = false;

        // Loop to iterate through the list and display the index of the matching item
        for (int i = 0; i < uniqueStrings.Count; i++)
        {
            if (uniqueStrings[i].Contains(searchText))
            {
                Console.WriteLine($"Found at index {i}: {uniqueStrings[i]}");
                found = true;
                break; // Stop the loop once a match has been found
            }
        }

        // Check if the user's input is not in the list
        if (!found)
        {
            Console.WriteLine($"'{searchText}' is not in the list.");
        }

        Console.WriteLine("-------------------------------");

        // Introduce a list of car manufacturers with at least two identical manufacturers
        List<string> carManufacturers = new List<string> { "Honda", "Toyota", "Acura", "Scion", "Mazda", "Honda" };

        // Ask the user to select a car manufacturer to search for in the list
        Console.Write("Enter a car manufacturer to search for in the list: ");
        string manufacturerSearchText = Console.ReadLine();

        // Loop to iterate through the carManufacturers list and display the indices of matching manufacturers
        Console.WriteLine("Matching Indices in the Car Manufacturers List:");
        for (int i = 0; i < carManufacturers.Count; i++)
        {
            if (carManufacturers[i].ToLower().Contains(manufacturerSearchText.ToLower()))
            {
                Console.WriteLine($"Found at index {i}: {carManufacturers[i]}");
                found = true;
            }
        }

        // Check if the user's input is not in the list of car manufacturers
        if (!found)
        {
            Console.WriteLine($"'{manufacturerSearchText}' is not a car manufacturer in the list.");
        }

        Console.WriteLine("-------------------------------");

        // Create a list of Lamborghini models
        List<string> lamborghiniModels = new List<string>
        { "Huracan", "Aventador", "Urus", "Huracan", "Gallardo", "Aventador" };

        // Create a dict to keep track of whether a model is unique or a duplicate
        Dictionary<string, string> modelStatus = new Dictionary<string, string>();

        // Loop through the list using foreach
        foreach (string model in lamborghiniModels)
        {
            // Check if the model is already in the dictionary
            if (modelStatus.ContainsKey(model))
            {
                Console.WriteLine($"{model} - this model is a duplicate");
            }
            else
            {
                // Add the model to the dictionary as unique
                modelStatus[model] = "unique";
                Console.WriteLine($"{model} - this model is unique");
            }
        }

        Console.WriteLine("-------------------------------");

        // Wait for user input before exiting
        Console.ReadLine();
    }
}
