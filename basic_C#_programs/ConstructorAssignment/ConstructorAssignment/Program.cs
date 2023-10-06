using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main()
        {
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
