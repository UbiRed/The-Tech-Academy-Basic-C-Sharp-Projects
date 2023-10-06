using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main()
        {
            // Define a constant variable
            const double pi = 3.14159;

            // Define a variable using the var keyword
            var Name1 = "Keaton";

            Console.WriteLine(Name1 + " " + pi);

            // base constructor
            Class1 obj1 = new Class1(10, "Hello");
            Console.WriteLine($"Value1: {obj1.value1}, Value2: {obj1.value2}");

            // chained constructor
            Class1 obj2 = new Class1();
            Console.WriteLine($"Value1: {obj2.value1}, Value2: {obj2.value2}");

            Console.ReadLine();
        }
    }
}
