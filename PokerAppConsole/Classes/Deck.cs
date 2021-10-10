using PokerAppConsole.Classes.enums;
using PokerAppConsole.Classes.Enums;
using PokerAppConsole.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerAppConsole.Classes
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }

        //constructor
        public Deck()
        {
            CreateDeck();
        }

        private void CreateDeck()
        {
            Cards = new List<Card>();
            foreach (CardType cardType in Enum.GetValues(typeof(CardType)))
            {
                foreach(CardValue cardValue in Enum.GetValues(typeof(CardValue)))
                {
                    Cards.Add(new Card(cardType, cardValue));
                }    
            }
        }
        private static Random rng = new Random();


        public void ShuffleDeck()
        {
            this.Cards.Shuffle();
        }

        public Card DrawCard()
        {
            var card = this.Cards.FirstOrDefault();
            this.Cards.RemoveAt(0);
            return card;
        }

    }
}
