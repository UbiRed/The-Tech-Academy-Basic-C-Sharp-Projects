using System;

// Create a class called Person


// Create another class called Employee that inherits from Person


class Program
{
    static void Main()
    {
        // Instantiate and initialize an Employee object
        Employee employee = new Employee("Sample", "Student", 12345);

        // Call the superclass method SayName() on the Employee object
        employee.SayName();

        Console.ReadLine(); // Wait for user input to exit
    }
}
