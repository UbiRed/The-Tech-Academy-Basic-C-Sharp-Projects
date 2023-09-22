using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a simple program
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is " +  yourName);
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favnum = Convert.ToInt32(favoriteNumber);
            int total = favnum + 5;
            Console.WriteLine("Your favorite number plus 5 is " +  total);
            Console.ReadLine() ;

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;

            double heightInCenti = 255.51654135;

            float secondsLeft = 2.65f;

            short tempOnMars = -341;

            string yourName = "Nick";

            int currentAge = 24;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

            Console.WriteLine(questionMark);
            Console.ReadLine();
        }
    }
}
