using System;

class Program
{
    static void Main()
    {
        // Instantiate two Employees
        Employee employee1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        Employee employee2 = new Employee
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Compare the Employees using overloaded "==" 
        bool areEqual = employee1 == employee2;

        // Display the result
        Console.WriteLine("Are the employees the samew? " + areEqual);
        Console.ReadLine();
    }
}
