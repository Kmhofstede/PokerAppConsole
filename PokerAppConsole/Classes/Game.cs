using PokerAppWeb.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerAppConsole.Classes
{
    public class Game
    {
        public Player Player1;
        public Player Player2;

        public Game()
        {
            SetupGame();
            
            //RunGame();

            //CheckWinner();
        }

        private void SetupGame()
        {
            Player1 = new Player();
            Player2 = new Player();

            Player1.ShuffleDeck();
            Player2.ShuffleDeck();

            Console.WriteLine("Decks are shuffled!");
        }

        public void RunGame()
        {
            
        }

        public void CheckWinner()
        {

        }
    }
}
