using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Blackjack!");

        while (true)
        {
            // Initialize a new deck of cards
            List<string> deck = CreateDeck();

            // Shuffle the deck
            ShuffleDeck(deck);

            // Deal two cards to the player and two cards to the dealer
            List<string> playerHand = new List<string>();
            List<string> dealerHand = new List<string>();

            playerHand.Add(DealCard(deck));
            dealerHand.Add(DealCard(deck));
            playerHand.Add(DealCard(deck));
            dealerHand.Add(DealCard(deck));

            // Display the initial hands
            Console.WriteLine($"Your hand: {string.Join(", ", playerHand)}");
            Console.WriteLine($"Dealer's hand: {dealerHand[0]}, [Hidden]");

            // Player's turn
            while (CalculateHandValue(playerHand) < 21)
            {
                Console.Write("Do you want to Hit or Stand? (H/S): ");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "H")
                {
                    playerHand.Add(DealCard(deck));
                    Console.WriteLine($"Your hand: {string.Join(", ", playerHand)}");
                }
                else if (choice == "S")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'H' or 'S'.");
                }
            }

            // Dealer's turn
            while (CalculateHandValue(dealerHand) < 17)
            {
                dealerHand.Add(DealCard(deck));
            }

            // Display final hands
            Console.WriteLine($"Your hand: {string.Join(", ", playerHand)}");
            Console.WriteLine($"Dealer's hand: {string.Join(", ", dealerHand)}");

            // Determine the winner
            int playerValue = CalculateHandValue(playerHand);
            int dealerValue = CalculateHandValue(dealerHand);

            if (playerValue > 21 || (dealerValue <= 21 && dealerValue >= playerValue))
            {
                Console.WriteLine("Dealer wins!");
            }
            else if (dealerValue > 21 || playerValue > dealerValue)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

            // Ask if the player wants to play again
            Console.Write("Do you want to play again? (Y/N): ");
            string playAgain = Console.ReadLine().ToUpper();
            if (playAgain != "Y")
            {
                break;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }

    // Create a deck of cards
    static List<string> CreateDeck()
    {
        List<string> deck = new List<string>();
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        foreach (string suit in suits)
        {
            foreach (string value in values)
            {
                deck.Add($"{value} of {suit}");
            }
        }

        return deck;
    }

    // Shuffle the deck using Fisher-Yates shuffle algorithm
    static void ShuffleDeck(List<string> deck)
    {
        Random rng = new Random();
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            string card = deck[k];
            deck[k] = deck[n];
            deck[n] = card;
        }
    }

    // Deal a card from the deck
    static string DealCard(List<string> deck)
    {
        string card = deck[0];
        deck.RemoveAt(0);
        return card;
    }

    // Calculate the value of a hand
    static int CalculateHandValue(List<string> hand)
    {
        int value = 0;
        int numAces = 0;

        foreach (string card in hand)
        {
            string[] cardParts = card.Split(' ');
            string cardValue = cardParts[0];

            if (cardValue == "Ace")
            {
                numAces++;
                value += 11;
            }
            else if (cardValue == "King" || cardValue == "Queen" || cardValue == "Jack")
            {
                value += 10;
            }
            else
            {
                value += int.Parse(cardValue);
            }
        }

        while (value > 21 && numAces > 0)
        {
            value -= 10;
            numAces--;
        }

        return value;
    }
}
