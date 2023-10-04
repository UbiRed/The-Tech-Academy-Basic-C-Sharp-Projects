using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor 1: Initialize properties with provided names
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Constructor 2: Initialize properties with default values
    public Person()
    {
        FirstName = "";
        LastName = "";
    }

    // Method getting full name of person
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}