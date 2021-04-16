using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Card
    {
        private string _suit;
        private string _cardValue;
        private string _displayValue;

        public string suit
        {
            get { return _suit; }
            set { _suit = suit; }
        }

        public string cardValue
        {
            get { return _cardValue; }
            set { _cardValue = cardValue; }
        }

        public string displayValue
        {
            get { return _displayValue; }
            set { _displayValue = displayValue; }
        }

        public Card(string definedSuit, string definedValue)
        {
            // set local variables to relevant given arguments
            _suit = definedSuit;
            _cardValue = definedValue;
            _displayValue = definedValue + " of " + definedSuit;
        }
    }
}
