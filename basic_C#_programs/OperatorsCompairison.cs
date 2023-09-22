using System;

class Program
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 4;

        // Addition
        int sum = num1 + num2;
        Console.WriteLine("Addition: " + sum);

        // Subtraction
        int difference = num1 - num2;
        Console.WriteLine("Subtraction: " + difference);

        // Multiplication
        int product = num1 * num2;
        Console.WriteLine("Multiplication: " + product);

        // Division (without casting)
        int divisionWithoutCasting = num1 / num2;
        Console.WriteLine("Division (without casting): " + divisionWithoutCasting);

        // Division (with casting to double)
        double divisionWithCasting = (double)num1 / num2;
        Console.WriteLine("Division (with casting): " + divisionWithCasting);

        // Modulus
        int modulus = num1 % num2;
        Console.WriteLine("Modulus: " + modulus);

        // Increment
        int increment = num1++;
        Console.WriteLine("Increment: " + increment);

        // Decrement
        int decrement = num2--;
        Console.WriteLine("Decrement: " + decrement);
    }
}