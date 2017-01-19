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

            Console.WriteLine("Enter Symbol for Player 1: ");
            board.player1Symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Symbol for Player 2: ");
            board.player2Symbol = Convert.ToChar(Console.ReadLine());


            board.printBoard();

            Console.WriteLine($"\n Player 1 Symbol: {board.player1Symbol}");
            Console.WriteLine($"\n Player 2 Symbol: {board.player2Symbol}");

            Console.ReadLine();

        }
    }
}
