using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerAppWeb.Classes
{
    public class Player
    {
        public string Name;
        public Deck PlayerDeck { get; set; }
        public List<Card> Hand { get; set; }

        const int maxCards = 5;

        //constructor
        public Player(string name)
        {
            this.Name = name;
            this.PlayerDeck = new Deck();
            this.Hand = new List<Card>();
        }
        

        public void ShuffleDeck()
        {
            PlayerDeck.ShuffleDeck();
        }

        public void DrawCards()
        {
            for(int i = 0; i < maxCards; i++)
            {
                var card = PlayerDeck.DrawCard();
                Hand.Add(card);
                Console.WriteLine(this.Name + " draws: " + card);
            }
        }
    }
}
