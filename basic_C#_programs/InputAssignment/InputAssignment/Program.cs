using System;
using System.IO;

namespace NumberLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Define the file path
            string filePath = @"C:\Users\keato\Documents\Logs\log.txt";

            
            // Write the user's input to the text file
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(userInput);
            }

            // Read and print the content of the text file
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Numbers in the log file:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
