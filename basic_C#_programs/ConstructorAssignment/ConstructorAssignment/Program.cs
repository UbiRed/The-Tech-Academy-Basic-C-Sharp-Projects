using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main()
        {
            Class1 obj1 = new Class1(42);
            obj1.DisplayValues();

            Class1 obj2 = new Class1(10, "Constructor successful");
            obj2.DisplayValues();
            Console.ReadLine();
        }
    }
}
