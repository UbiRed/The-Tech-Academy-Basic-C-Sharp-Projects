using System;

class Program
{
    static void Main()
    {
        // Prompt the user for age
        Console.WriteLine("What is your age?");
        int age = int.Parse(Console.ReadLine());

        // Prompt the user for DUI history
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        bool hasDUI = bool.Parse(Console.ReadLine());

        // Prompt the user for speeding tickets count
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = int.Parse(Console.ReadLine());

        // Check if the applicant qualifies for car insurance
        bool isQualified = age > 15 && !hasDUI && speedingTickets <= 3;

        
        Console.WriteLine("Qualified? " + isQualified);
        // Display results
        Console.ReadLine();
    }
}
 