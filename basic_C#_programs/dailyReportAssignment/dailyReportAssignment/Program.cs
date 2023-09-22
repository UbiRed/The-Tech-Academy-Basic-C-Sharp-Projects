using System;

namespace dailyReportAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the header
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            // Declare variables to store user input
            string name;
            string course;
            int pageNumber;
            bool needHelp;
            string positiveExperiences;
            string feedback;
            int studyHours;

            // Ask for and save user input
            Console.Write("What is your name? ");
            name = Console.ReadLine();

            Console.Write("What course are you on? ");
            course = Console.ReadLine();

            Console.Write("What page number are you on? ");
            // Use int.TryParse to handle invalid input
            int.TryParse(Console.ReadLine(), out pageNumber);

            Console.Write("Do you need help with anything? Please answer 'true' or 'false': ");
            // Use bool.TryParse to handle invalid input
            bool.TryParse(Console.ReadLine(), out needHelp);

            Console.Write("Were there any positive experiences you'd like to share? Please give specifics: ");
            positiveExperiences = Console.ReadLine();

            Console.Write("Is there any other feedback you'd like to provide? Please be specific: ");
            feedback = Console.ReadLine();

            Console.Write("How many hours did you study today? ");
            // Use int.TryParse to handle invalid input
            int.TryParse(Console.ReadLine(), out studyHours);

            // Print the closing message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }

    }
}
