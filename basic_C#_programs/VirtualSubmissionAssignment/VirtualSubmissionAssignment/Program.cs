using System;

class Program
{
    static void Main()
    {
        // Instantiate an Employee object
        Employee employee = new Employee
        {
            FirstName = "Sample",
            LastName = "Student"
        };

        // Call the SayName method
        employee.SayName();

        Console.ReadLine();
    }
}
