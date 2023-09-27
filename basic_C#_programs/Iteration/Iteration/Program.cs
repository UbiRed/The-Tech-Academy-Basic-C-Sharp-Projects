using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int[] testScores = { 98, 99, 34, 55, 67, 89, 92, 88 };

        for (int i = 0; i < testScores.Length; i++)
        {
            if (testScores[i] > 85)
            {
            Console.WriteLine("Passing test score: " + testScores[i]);
            }
        }
    Console.ReadLine();
    }
}