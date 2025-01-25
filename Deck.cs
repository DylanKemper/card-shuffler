using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Cards;

namespace Decks
{
    internal class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            this.cards = new List<Card>();
            CreateDeck();
            DisplayDeck();
        }

        private void CreateDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (FaceValue value in Enum.GetValues(typeof(FaceValue)))
                {
                    this.cards.Add(new Card(value, suit));
                }
            }
        }

        private void DisplayDeck()
        {
            foreach (Card card in cards)
            {
                card.DisplayCard();
            }
        }
    }
}
