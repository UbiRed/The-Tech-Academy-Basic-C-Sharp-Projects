using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ubi Hotel and Casino! \n--------------------------- \nWhat is your name? ");
            string playerName = Console.ReadLine();

            Console.WriteLine("---------------------------\nHow much money are you gambling with today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------\nHello, {0}! Would you like to play a game of Blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" ||  answer == "yeah" || answer == "ya" || answer == "y" || answer == "true" || answer == "si") 
            {
                Console.WriteLine("\n\n");
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivePlaying = true;

                while (player.isActivePlaying && player.Balance > 0) 
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Bye.");

            Console.ReadLine();
        }
    }
}