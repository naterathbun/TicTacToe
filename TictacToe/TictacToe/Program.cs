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

            AssignSymbols(1, board);
            AssignSymbols(2, board);

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
            Console.WriteLine(board.theWinner);
            Console.ReadLine();
        }

        public static void AssignSymbols(int player, Board theBoard)
        {
            while (true)
            {
                char playerInput;
                bool isInputValid;
                Console.Write($"Enter Symbol for Player {player}: ");
                isInputValid = char.TryParse(Console.ReadLine(), out playerInput);
                if (playerInput == ' ')
                {
                    isInputValid = false;
                }
                if (isInputValid)
                {
                    theBoard.SetPlayerSymbols(playerInput, player);
                    break;
                }
            }

        }
    }
}
