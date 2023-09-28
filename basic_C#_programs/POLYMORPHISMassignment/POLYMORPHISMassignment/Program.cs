using System;


class Program
{
    static void Main()
    {
        // Create an Employee object
        Employee employee = new Employee
        {
            FirstName = "John",
            LastName = "Doe"
        };

        // Create an IQuittable reference and assign it to the Employee object
        IQuittable quittableEmployee = employee;

        // Call the Quit method using polymorphism
        quittableEmployee.Quit();

        // Wait for user input before exiting
        Console.ReadLine();
    }
}
