using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.Write("Please enter the package weight: ");
        double weight = double.Parse(Console.ReadLine());

        // Check if the package weight is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            // Prompt user for package dimensions
            Console.Write("Please enter the package width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            double length = double.Parse(Console.ReadLine());

            // Calculate the product of dimensions and multiply by weight, then divide by 100
            double dimensionsTotal = width * height * length;

            // Check if dimensions total is greater than 50 and display an error message
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package is too big to ship via Package Express.");
            }
            else
            {
                // Calculate the shipping quote
                double quote = (dimensionsTotal * weight) / 100;

                // Display the quote to the user as a dollar amount
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));

                // Check if the quote is less than $100 and display an additional message
                if (quote < 100)
                {
                    Console.WriteLine("Shipping cost is less than $100. What a deal!");
                }
            }
        }

        // Display thank you message
        Console.WriteLine("Thank you!");

        Console.ReadLine();
    }
}
