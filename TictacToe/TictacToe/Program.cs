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
            char playerInput;
            bool isInputValid;
            Board board = new Board();

            Console.WriteLine(" _____ _        _____            _____");
            Console.WriteLine("|_   _(_) ___  |_   _|_ _  ___  |_   _|__   ___");
            Console.WriteLine("  | | | |/ __|   | |/ _` |/ __|   | |/ _ \\ / _ \\");
            Console.WriteLine("  | | | | (__    | | (_| | (__    | | (_) |  __/");
            Console.WriteLine("  |_| |_|\\___|   |_|\\__,_|\\___|   |_|\\___/ \\___|\n");

            while (true)
            {
                Console.Write("Enter Symbol for Player 1: ");
                isInputValid = char.TryParse(Console.ReadLine(), out playerInput);
                if (playerInput == ' ')
                {
                    isInputValid = false;
                }
                if (isInputValid)
                {
                    board.SetPlayerSymbols(playerInput, 1);
                    break;
                }
            }
            while (true)
            {
                isInputValid = false;
                Console.Write("Enter Symbol for Player 2: ");
                isInputValid = char.TryParse(Console.ReadLine(), out playerInput);
                if (playerInput == ' ')
                {
                    isInputValid = false;
                }
                if (isInputValid)
                {
                    board.SetPlayerSymbols(playerInput, 2);
                    break;
                }
            }

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
    }
}
