using System;

class Employee : Person, IQuittable
{
    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"Employee {FirstName} {LastName} has quit.");
    }
}