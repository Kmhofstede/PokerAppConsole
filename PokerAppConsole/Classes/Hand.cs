using PokerAppConsole.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerAppConsole.Classes
{
    public class Hand
    {
        public int highcard;
        public PokerHand HandValue;
        public List<Card> PlayerHand { get; private set; }
        public IOrderedEnumerable<Card> SortedCollection { get; private set; }

        private int Hearths = 0;
        private int Clubs = 0;
        private int Spades = 0;
        private int Diamonds = 0;
        

        public Hand()
        {
            this.PlayerHand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            this.PlayerHand.Add(card);
        }

        public void CheckHand()
        {
            SortHand();
            foreach(var card in PlayerHand)
            {
                if(card.CardType == enums.CardType.CLUBS)
                {
                    this.Clubs++;
                }
                else if (card.CardType == enums.CardType.DIAMONDS)
                {
                    this.Diamonds++;
                }
                else if (card.CardType == enums.CardType.HEARTHS)
                {
                    this.Hearths++;
                }
                else if (card.CardType == enums.CardType.SPADES)
                {
                    this.Spades++;
                }
            }

            SetHandValue();
            Console.WriteLine(this.HandValue);
        }

        private void SetHandValue()
        {
            if (RoyalFlush())
            {
                this.HandValue = PokerHand.ROYALFLUSH;

            }
            else if (StraightFlush())
            {
                this.HandValue = PokerHand.STRAIGHTFLUSH;
            }
            else if (FourOfAKind())
            {
                this.HandValue = PokerHand.FOUROFAKIND;
            }
            else if (FullHouse())
            {
                this.HandValue = PokerHand.FULLHOUSE;
            }
            else if (Flush())
            {
                this.HandValue = PokerHand.FLUSH;
            }
            else if (Straight())
            {
                this.HandValue = PokerHand.STRAIGHT;
            }
            else if (ThreeOfAKind())
            {
                this.HandValue = PokerHand.THREEOFAKIND;
            }
            else if (TwoPair())
            {
                this.HandValue = PokerHand.TWOPAIR;
            }
            else if (OnePair())
            {
                this.HandValue = PokerHand.ONEPAIR;
            }
            else
            {
                this.HandValue = PokerHand.HIGHCARD;
            }
        }

        private bool OnePair()
        {
            if(this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(1).CardValue)
            {
                return true;
            }
            else if (this.SortedCollection.ElementAt(1).CardValue == this.SortedCollection.ElementAt(2).CardValue)
            {
                return true;
            }
            else if (this.SortedCollection.ElementAt(2).CardValue == this.SortedCollection.ElementAt(3).CardValue)
            {
                return true;
            }
            else if (this.SortedCollection.ElementAt(3).CardValue == this.SortedCollection.ElementAt(4).CardValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TwoPair()
        {
            if (this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(1).CardValue && this.SortedCollection.ElementAt(2).CardValue == this.SortedCollection.ElementAt(3).CardValue)
            {
                return true;
            }
            else if (this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(1).CardValue && this.SortedCollection.ElementAt(3).CardValue == this.SortedCollection.ElementAt(4).CardValue)
            {
                return true;
            }
            else if (this.SortedCollection.ElementAt(1).CardValue == this.SortedCollection.ElementAt(2).CardValue && this.SortedCollection.ElementAt(3).CardValue == this.SortedCollection.ElementAt(4).CardValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ThreeOfAKind()
        {
            if (this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(1).CardValue && this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(2).CardValue)
            {
                return true;
            }
            else if (this.SortedCollection.ElementAt(1).CardValue == this.SortedCollection.ElementAt(2).CardValue && this.SortedCollection.ElementAt(1).CardValue == this.SortedCollection.ElementAt(3).CardValue)
            {
                return true;
            }
            else if (this.SortedCollection.ElementAt(2).CardValue == this.SortedCollection.ElementAt(3).CardValue && this.SortedCollection.ElementAt(2).CardValue == this.SortedCollection.ElementAt(4).CardValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Straight()
        {
            if (this.SortedCollection.ElementAt(0).CardValue + 1 == this.SortedCollection.ElementAt(1).CardValue &&
                this.SortedCollection.ElementAt(1).CardValue + 1 == this.SortedCollection.ElementAt(2).CardValue &&
                this.SortedCollection.ElementAt(2).CardValue + 1 == this.SortedCollection.ElementAt(3).CardValue &&
                this.SortedCollection.ElementAt(3).CardValue + 1 == this.SortedCollection.ElementAt(4).CardValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Flush()
        {
            if (Hearths == 5 || Clubs == 5 || Diamonds == 5 || Spades == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool FullHouse()
        {
            //if 1 2 and 3 are same
            if (this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(1).CardValue && this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(2).CardValue)
            {
                //and if 4 and 5 are same
                if (this.SortedCollection.ElementAt(3).CardValue == this.SortedCollection.ElementAt(4).CardValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // if 3 4 5 are same
            else if (this.SortedCollection.ElementAt(2).CardValue == this.SortedCollection.ElementAt(3).CardValue && this.SortedCollection.ElementAt(2).CardValue == this.SortedCollection.ElementAt(4).CardValue)
            {
                //and if 1 and 2 are same
                if (this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(1).CardValue)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool FourOfAKind()
        {
            //if 1 2 3 4
            if (this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(1).CardValue 
                && this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(2).CardValue
                && this.SortedCollection.ElementAt(0).CardValue == this.SortedCollection.ElementAt(3).CardValue)
            {
                return true;
            }
            // or if 2 3 4 5
            else if (this.SortedCollection.ElementAt(1).CardValue == this.SortedCollection.ElementAt(2).CardValue
                && this.SortedCollection.ElementAt(1).CardValue == this.SortedCollection.ElementAt(3).CardValue
                && this.SortedCollection.ElementAt(1).CardValue == this.SortedCollection.ElementAt(4).CardValue)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        private bool StraightFlush()
        {
            if(Flush() && Straight())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool RoyalFlush()
        {
            if(Flush() && Straight())
            {
                if (this.SortedCollection.ElementAt(0).CardValue == CardValue.TEN && this.SortedCollection.ElementAt(4).CardValue == CardValue.ACE)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void SortHand()
        {
           this.SortedCollection = this.PlayerHand.OrderBy(c => (int)c.CardValue);
            foreach(var card in SortedCollection)
            {
                Console.WriteLine(card);
            }
        }
    }
}
