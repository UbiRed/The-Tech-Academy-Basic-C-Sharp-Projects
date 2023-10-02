using System;
using System.Collections.Generic;
using System.Linq;

// Define the Employee class with properties Id, FirstName, and LastName
class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list of at least 10 employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Alice", LastName = "Johnson" },
            new Employee { Id = 3, FirstName = "Bob", LastName = "Wilson" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Brown" },
            new Employee { Id = 5, FirstName = "Eva", LastName = "Davis" },
            new Employee { Id = 6, FirstName = "Mike", LastName = "Lee" },
            new Employee { Id = 7, FirstName = "Sarah", LastName = "Johnson" },
            new Employee { Id = 8, FirstName = "Joe", LastName = "Clark" },
            new Employee { Id = 9, FirstName = "David", LastName = "Moore" },
            new Employee { Id = 10, FirstName = "Linda", LastName = "White" }
        };

        // Using a foreach loop to create a list of employees with the first name "Joe"
        List<Employee> joes = new List<Employee>();
        foreach (Employee employee in employees)
        {
            if (employee.FirstName == "Joe")
            {
                joes.Add(employee);
            }
        }

        // Using a lambda expression to create a list of employees with first name "Joe"
        List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

        // Using a lambda expression to create a list of employees with an Id greater than 5
        List<Employee> idGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

        // Print the results
        Console.WriteLine("Employees with the first name 'Joe' (foreach loop):");
        foreach (Employee joe in joes)
        {
            Console.WriteLine($"{joe.FirstName} {joe.LastName}");
        }

        Console.WriteLine("\nEmployees with the first name 'Joe' (lambda expression):");
        foreach (Employee joe in joesLambda)
        {
            Console.WriteLine($"{joe.FirstName} {joe.LastName}");
        }

        Console.WriteLine("\nEmployees with Id greater than 5 (lambda expression):");
        foreach (Employee employee in idGreaterThan5)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}, ID: {employee.Id}");
        }
    }
}
