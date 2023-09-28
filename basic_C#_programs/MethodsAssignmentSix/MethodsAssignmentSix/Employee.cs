using System;

class Employee : Person
{
    // Property for Employee Id
    public int Id { get; set; }

    // Constructor to initialize FirstName, LastName, and Id
    public Employee(string firstName, string lastName, int id)
        : base(firstName, lastName)
    {
        Id = id;
    }
}