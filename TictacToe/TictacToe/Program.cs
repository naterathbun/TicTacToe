using TictacToe.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            Console.WriteLine(" _____ _        _____            _____");
            Console.WriteLine("|_   _(_) ___  |_   _|_ _  ___  |_   _|__   ___");
            Console.WriteLine("  | | | |/ __|   | |/ _` |/ __|   | |/ _ \\ / _ \\");
            Console.WriteLine("  | | | | (__    | | (_| | (__    | | (_) |  __/");
            Console.WriteLine("  |_| |_|\\___|   |_|\\__,_|\\___|   |_|\\___/ \\___|\n");
            board.SetPlayerSymbols();

            while (true)                            
            {
                board.NextTurn();                   
                while (!board.isTurnOver)
                {
                    board.AddPlayerSymbol();
                }
                if (board.IsTheGameOver())
                {
                    break;
                }
            }
            board.DeclareWinner();                  
        }
    }
}
