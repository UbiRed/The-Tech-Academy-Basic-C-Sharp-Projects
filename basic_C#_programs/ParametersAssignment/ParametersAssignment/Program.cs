using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Instantiate an Employee with type "string" and assign a list of strings
        Employee<string> stringEmployee = new Employee<string>();
        stringEmployee.Things.AddRange(new List<string> { "Apple", "Orange", "Blueberry" });

        // Instantiate an Employee object with type "int" and assign a list of integers
        Employee<int> intEmployee = new Employee<int>();
        intEmployee.Things.AddRange(new List<int> { 1, 2, 3, 4, 5 });

        // Loop through and print all the Things for the stringEmployee
        Console.WriteLine("String Employee's Things:");
        foreach (var item in stringEmployee.Things)
        {
            Console.WriteLine(item);
        }

        // Loop through and print all the Things for the intEmployee
        Console.WriteLine("\nInt Employee's Things:");
        foreach (var item in intEmployee.Things)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}
