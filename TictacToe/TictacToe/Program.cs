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
            board.humanOrAI = Console.ReadLine();
            
            Console.WriteLine("Enter Symbol for Player 1: ");
            board.player1Symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Symbol for Player 2 or AI: ");
            board.player2Symbol = Convert.ToChar(Console.ReadLine());
            */
            while (true)
            {

                while (!board.isTurnOver) //player1
                {
                    board.printBoard();
                    Console.WriteLine("Player 1's Turn: Choose an unoccupied square (by number):");
                    board.AddPlayer1Symbol();
                }

                board.NextTurn();

                while (!board.isTurnOver)
                {
                    board.printBoard();
                    Console.WriteLine("Player 2's Turn: Choose an unoccupied square (by number):");
                    board.AddPlayer2Symbol();
                }

                board.NextTurn();


                /*  if (board.isGameOver()_
                    {
                        break;
                    } */

            }
            Console.ReadLine(); //keep window open
        }
    }
}
