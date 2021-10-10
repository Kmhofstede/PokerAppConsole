using PokerAppConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerAppConsole.Classes
{
    public class Player
    {
        public string Name;
        public Deck PlayerDeck { get; set; }

        public Hand PlayerHand { get; set; }
        public List<Card> Hand { get; set; }

        const int maxCards = 5;

        //constructor
        public Player(string name)
        {
            this.Name = name;
            this.PlayerDeck = new Deck();
            this.Hand = new List<Card>();
            this.PlayerHand = new Hand();
        }
        

        public void ShuffleDeck()
        {
            PlayerDeck.ShuffleDeck();
        }

        public void DrawCards()
        {
            PlayerHand = new Hand();
            for (int i = 0; i < maxCards; i++)
            {
                var card = PlayerDeck.DrawCard();
                this.PlayerHand.AddCard(card);
                Console.WriteLine(this.Name + " draws: " + card);
            }
        }

        public void CheckHand()
        {
            PlayerHand.CheckHand();
        }
    }
}
