using System;

namespace ConstructorAssignment
{
    class Class1
    {
        private int value1;
        private string value2;

        // Constructor with one parameter
        public Class1(int v1)
        {
            value1 = v1;
        }

        // Constructor with two parameters, chaining the first constructor
        public Class1(int v1, string v2) : this(v1)
        {
            value2 = v2;
        }

        public void DisplayValues()
        {
            Console.WriteLine("Value1: " + value1);
            Console.WriteLine("Value2: " + value2);
        }
    }
}
