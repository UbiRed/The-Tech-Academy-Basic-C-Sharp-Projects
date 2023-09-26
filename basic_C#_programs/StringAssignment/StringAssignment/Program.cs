using System;
using System.Text; // Import the System.Text namespace for StringBuilder

class Program
{
    static void Main()
    {
        // Task 1: Concatenate Three Strings

        // Declare and initialize three strings
        string string1 = "Hello, ";
        string string2 = "world";
        string string3 = "!";

        // Concatenate the three strings
        string concatenatedString = string1 + string2 + string3;

        // Display the concatenated string
        Console.WriteLine("Concatenated String: " + concatenatedString);

        // Task 2: Convert a String to Uppercase

        string originalString = "convert me to uppercase";

        // Convert the string to uppercase using the ToUpper() method
        string uppercaseString = originalString.ToUpper();

        // Display the uppercase string
        Console.WriteLine("Uppercase String: " + uppercaseString);

        // Task 3: Create a StringBuilder and Build a Paragraph

        // Create a StringBuilder to build a paragraph
        StringBuilder paragraph = new StringBuilder();

        // Append sentences to the StringBuilder, one at a time
        paragraph.Append("This is the first sentence. ");
        paragraph.Append("Here is the second sentence. ");
        paragraph.Append("And this is the third sentence. ");

        // Convert the StringBuilder to a string
        string finalParagraph = paragraph.ToString();

        // Display the final paragraph
        Console.WriteLine("Built Paragraph:\n" + finalParagraph);

        // Wait for user input before exiting
        Console.ReadLine();
    }
}
