using System;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor 1: Initialize properties with provided first name
    public Person(string firstName)
    {
        FirstName = firstName;
        LastName = "Doe";
    }

    // Constructor 2: Initialize properties with default values
    public Person()
    {
        FirstName = "John";
        LastName = "Doe";
    }

    // Method getting full name of person
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
}
