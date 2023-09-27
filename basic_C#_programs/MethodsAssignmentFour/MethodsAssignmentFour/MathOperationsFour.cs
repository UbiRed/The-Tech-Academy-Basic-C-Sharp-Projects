using System;

public class MathOperations
{
    // Create a method that takes two integers as parameters, with one of them being optional
    public int PerformOperation(int number1, int number2 = 0)
    {
        // Perform a math operation (addition by default) on number1 and number2
        int result = number1 + number2;
        return result;
    }
}