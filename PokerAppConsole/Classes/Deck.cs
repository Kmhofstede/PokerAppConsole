using PokerAppConsole.Providers;
using PokerAppWeb.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerAppWeb.Classes
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

        public void DrawCard()
        {

        }

    }
}
