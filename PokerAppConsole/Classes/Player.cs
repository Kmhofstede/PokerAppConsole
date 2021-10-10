using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerAppWeb.Classes
{
    public class Player
    {
        public Deck PlayerDeck { get; set; }
        public List<Card> Hand { get; set; }

        //constructor
        public Player()
        {
            this.PlayerDeck = new Deck();
        }
        

        public void ShuffleDeck()
        {
            PlayerDeck.ShuffleDeck();
        }

        public void DrawCard()
        {

        }
    }
}
