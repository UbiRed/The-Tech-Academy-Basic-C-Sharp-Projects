using System;
using System.Collections.Generic;


class Employee<T>
{
    public List<T> Things { get; set; }

    // Constructor to initialize the list
    public Employee()
    {
        Things = new List<T>();
    }
}