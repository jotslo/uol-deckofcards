using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Deck
    {
        private List<Card> _cardDeck;
        private Random random = new Random();
        private string[] _suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        private string[] _values =
            { "A", "1", "2", "3", "4", "5", "6",
            "7", "8", "9", "10", "J", "Q", "K" };

        public List<Card> cardDeck
        {
            get { return _cardDeck; }
            set { _cardDeck = cardDeck; }
        }

        public void Shuffle()
        {
            // while deckpointer greater than 1, decrease by 1
            // switch element at index with random element
            int deckPointer = cardDeck.Count;
            while (deckPointer > 1)
            {
                deckPointer--;
                int otherIndex = random.Next(deckPointer + 1);
                Card tempCard = cardDeck[otherIndex];
                cardDeck[otherIndex] = cardDeck[deckPointer];
                cardDeck[deckPointer] = tempCard;
            }
        }

        public bool IsEmpty()
        {
            // return true/false depending on whether card deck is empty
            return _cardDeck.Count == 0;
        }

        public Card Deal()
        {
            // if deck not empty, get first top card, remove from deck and return
            if (!IsEmpty())
            {
                Card chosenCard = cardDeck[0];
                cardDeck.RemoveAt(0);

                return chosenCard;
            }

            // otherwise, return nothing
            return null;
        }

        public Deck()
        {
            // for each suit and card value, create new card and add to deck
            _cardDeck = new List<Card>();
            foreach (string suit in _suits)
            {
                foreach (string value in _values)
                {
                    _cardDeck.Add(new Card(suit, value));
                }
            }
        }
    }
}
