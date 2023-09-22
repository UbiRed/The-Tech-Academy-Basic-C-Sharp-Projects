using System;

class Program
{
    static void Main()
    {
        // Print program header
        Console.WriteLine("Anonymous Income Comparison Program");

        // Person 1 input
        Console.WriteLine("Person 1");
        Console.Write("Hourly Rate? ");
        double hourlyRate1 = double.Parse(Console.ReadLine()); // Get hourly rate
        Console.Write("Hours worked per week? ");
        double hoursWorkedPerWeek1 = double.Parse(Console.ReadLine()); // Get hours worked per week

        // Person 2 input
        Console.WriteLine("Person 2");
        Console.Write("Hourly Rate? ");
        double hourlyRate2 = double.Parse(Console.ReadLine()); // Get hourly rate
        Console.Write("Hours worked per week? ");
        double hoursWorkedPerWeek2 = double.Parse(Console.ReadLine()); // Get hours worked per week

        // Calculate annual salaries (Multiply weekly earnings by 52)
        double annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;
        double annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

        // Print annual salaries
        Console.WriteLine("Annual salary of Person 1:");
        Console.WriteLine(annualSalary1.ToString("N0"));
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(annualSalary2.ToString("N0"));

        // Check if Person 1 makes more money than Person 2
        bool person1MakesMore = annualSalary1 > annualSalary2;

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(person1MakesMore);
        Console.ReadLine(); // Display Results
    }
}
