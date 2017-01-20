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

            /* Console.WriteLine("Do you want to play against human or AI?");
            board.humanOrAI = Console.ReadLine();*/
            

            
            while (true)
            {
                board.NextTurn();
                while (!board.isTurnOver) //player1
                {
                    board.PrintBoard();
                    Console.WriteLine("Player 1's Turn: Choose an unoccupied square (by number):");
                    board.AddPlayer1Symbol();
                }
                if (board.IsTheGameOver())
                {
                    break;
                }

                board.NextTurn();
                while (!board.isTurnOver) //player2
                {
                    board.PrintBoard();
                    Console.WriteLine("Player 2's Turn: Choose an unoccupied square (by number):");
                    board.AddPlayer2Symbol();
                }
                if (board.IsTheGameOver())
                {
                    break;
                }
            }
            Console.WriteLine(board.theWinner);
            Console.ReadLine(); //keep window open
        }
    }
}
