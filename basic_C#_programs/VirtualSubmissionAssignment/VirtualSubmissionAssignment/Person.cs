using System;

abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Abstract method SayName
    public abstract void SayName();
}