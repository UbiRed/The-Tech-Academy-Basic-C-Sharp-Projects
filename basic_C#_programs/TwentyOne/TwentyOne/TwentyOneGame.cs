﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            Console.Write("Your turn to place your bet: ");

            foreach (Player player in Players )
            {               
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet) 
                {
                    return;
                }
                Bets[player] = bet;
            }

            for (int i = 0; i < 2;  i++)
            {
                Console.WriteLine("\nDealing...\n");
                foreach (Player player in Players) 
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);

                    if (i == 1) 
                    {
                        bool blackJack = TwentyOneRules.CheckForBj(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }

                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);

                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBj(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has blackjack! House wins, your lose.");

                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your hand: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }

                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "stay" || answer == "Stay" || answer == "S" || answer == "s")
                    {
                        player.Stay = true;
                    }

                    else if (answer == "hit" || answer == "Hit" || answer == "H" || answer == "h")
                    {
                        Dealer.Deal(player.Hand);
                    }

                    bool busted = TwentyOneRules.isBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);

                        Console.WriteLine("\nDo you want to play another hand?");
                        answer = Console.ReadLine().ToLower();

                        if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y" || answer == "true" || answer == "si")
                        {
                            player.isActivePlaying = true;
                        }

                        else
                        {
                            player.isActivePlaying = false;
                        }
                    }
                }
            }

            Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.shouldDealerStay(Dealer.Hand);

            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.isBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.shouldDealerStay(Dealer.Hand);
            }

            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }

            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer is busted!");

                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} wins {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }

            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);

                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins");
                    player.Balance += Bets[player];
                }

                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }

                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();

                if (answer == "yes" || answer == "yeah" || answer == "ya" || answer == "y" || answer == "true" || answer == "si")
                {
                    player.isActivePlaying = true;
                }

                else
                {
                    player.isActivePlaying = false;
                }
            }

            
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Black Jack Players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
