using System;
using System.Data;
using System.Data.SqlClient;
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
                    catch (FraudException ex)
                    {
                        Console.WriteLine("Security! Kick this cheater out of the casino!");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error has occured. Please contact your Systems Admin.");
                        UpdateDbWithException(ex);
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
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TwentyOneGame;" +
                                        "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                                        "Trust Server Certificate=True;Application Intent=ReadWrite;" +
                                        "Multi Subnet Failover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}