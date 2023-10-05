using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main()
        {
            // Create a constant variable for pi
            const double Pi = 3.14159;

            // Create a variable using the "var" keyword
            var greeting = "Hello, World!";

            // Create a person object using the overloaded constructor
            Person person = new Person("John");

            // Display constant, variable, and person's full name
            Console.WriteLine("Value of Pi: " + Pi);
            Console.WriteLine("Greeting: " + greeting);
            Console.WriteLine("Full Name: " + person.GetFullName());

            Console.ReadLine();
        }
    }
}
