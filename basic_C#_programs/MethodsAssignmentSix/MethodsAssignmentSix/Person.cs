using System;

class Person
{
    // Two properties for FirstName and LastName
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor to initialize FirstName and LastName
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Void method to print the person's full name
    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}