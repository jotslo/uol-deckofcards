using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user's deck
            Deck userDeck = new Deck();

            // Shuffle deck into random order
            userDeck.Shuffle();

            while (true)
            {
                // request input from user to deal next card
                Console.WriteLine("Press enter to get card from deck... ");
                string input = Console.ReadLine();

                // deal card from top of deck
                Card card = userDeck.Deal();

                // if card is of card type, output
                if (card is Card)
                {
                    Console.WriteLine(card.displayValue);
                }

                // otherwise, output error and end program
                else
                {
                    Console.WriteLine("Deck is empty");
                    break;
                }
            }
        }
    }
}
