using System;

class Employee : Person
{
    // SayName method for Employee
    public override void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}