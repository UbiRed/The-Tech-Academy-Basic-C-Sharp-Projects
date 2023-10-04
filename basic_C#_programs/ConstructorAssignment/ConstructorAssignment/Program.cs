using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a constant var for pi
            const double Pi = 3.14159;

            // Create var using the "var" keyword
            var greeting = "Hello, World!";

            // Chain two constructors to create a person object
            Person person = new Person("Keaton", "Kupillas");

            // Display constant, variable, and person's full name
            Console.WriteLine("Value of Pi: " + Pi);
            Console.WriteLine("Greeting: " + greeting);
            Console.WriteLine("Full Name: " + person.GetFullName());

            Console.ReadLine();
        }
    }    
}
