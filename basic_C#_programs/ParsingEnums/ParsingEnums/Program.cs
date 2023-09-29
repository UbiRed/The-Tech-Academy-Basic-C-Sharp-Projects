using System;


class Program
{
    static void Main()
    {
        try
        {
            // Prompt the user to enter current day of the week
            Console.Write("Enter the current day of the week: ");
            string userInput = Console.ReadLine();

            // Convert the user input to the enum type (DaysOfWeek)
            DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

            // Display the current day
            Console.WriteLine($"Today is {currentDay}.");
        }
        catch (ArgumentException)
        {
            // Handle invalid input
            Console.WriteLine("Please enter an actual day of the week.");
        }
        catch (Exception ex)
        {
            // Other exceptions
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.ReadLine();
    }
}
