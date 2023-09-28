using System;

class Employee : Person
{
    // Implement the SayName method for Employee
    public override void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}