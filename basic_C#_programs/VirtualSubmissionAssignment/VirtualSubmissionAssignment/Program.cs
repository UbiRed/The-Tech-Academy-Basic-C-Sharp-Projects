using System;

class Program
{
    static void Main()
    {
        // Instantiate an Employee object with firstName “Sample” and lastName “Student”
        Employee employee = new Employee
        {
            FirstName = "Sample",
            LastName = "Student"
        };

        // Call the SayName method on the object
        employee.SayName();

        // Wait for user input before exiting
        Console.ReadLine();
    }
}
