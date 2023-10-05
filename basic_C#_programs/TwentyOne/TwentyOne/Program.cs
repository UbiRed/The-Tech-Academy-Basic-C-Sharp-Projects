using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    internal class Program
    {
        private static char card;

        static void Main(string[] args)
        {
            const string casinoName = "Ubi Hotel and Casino";

            

            Console.WriteLine("Welcome to the {0}! \n--------------------------- \nWhat is your name? ",casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("How much money are you gambling with today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals!");
            }

            Console.WriteLine("---------------------------\nHello, {0}! Would you like to play a game of Blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" ||  answer == "yeah" || answer == "ya" || answer == "y" || answer == "true" || answer == "si") 
            {
                Console.WriteLine("\n\n");
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\keato\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\basic_C#_programs\TwentyOne\Logs\log.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(card);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlaying = true;

                while (player.isActivePlaying && player.Balance > 0) 
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this cheater out of the casino!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error has occured. Please contact your Systems Admin.");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Bye.");

            Console.ReadLine();
        }
        private static void UpdateDbWithException(Exception ex)
        {
            
        }
    }
}