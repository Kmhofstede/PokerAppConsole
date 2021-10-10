using PokerAppConsole.Classes.enums;
using PokerAppConsole.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerAppConsole.Classes
{
    public class Card
    {
        public CardType CardType { get; set; }
        public CardValue CardValue { get; set; }

        public Card(CardType cardType, CardValue cardValue)
        {
            this.CardType = cardType;
            this.CardValue = cardValue;
        }

        public override string ToString()
        {
            return CardType + " " + CardValue;
        }
    }
}
