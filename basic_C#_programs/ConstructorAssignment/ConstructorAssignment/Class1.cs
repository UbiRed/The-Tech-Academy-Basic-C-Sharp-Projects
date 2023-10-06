using System;

namespace ConstructorAssignment
{
    class Class1
    {
        public int value1;
        public string value2;

        // Base constructor 
        public Class1(int v1, string v2)
        {
            this.value1 = v1;
            this.value2 = v2;
        }
        // Chained Constructor
        public Class1() : this(0, "")
        {
        }
    }
}
