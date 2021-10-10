using PokerAppConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerAppConsole
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start");
            Console.WriteLine("Press esc to exit");
            
            do
            {
                if(Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("play");
                    Game Game = new Game();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
