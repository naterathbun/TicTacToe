using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToe.Classes
{
    class Board
    {
        public List<char> boardTally = new List<char>();
        public char player1Symbol;
        public char player2Symbol;

        public Board()                                  // blank the board
        {
            for (int i = 0; i < 9; i++)
            {
                boardTally.Add(' ');
            }
        }

        public bool addPlayer1Symbol(int location)      // takes location, if available set board[location] to player symbol, if not return false
        {
            if ((location <= 9) && (location >= 0) && (boardTally[location] != ' '))
            {
                boardTally[location] = player1Symbol;
                return true;
            }
            return false;
        }

        public void printBoard()
        {
            Console.WriteLine($"\n  __________________________");
            Console.WriteLine($"/|                          |\\");
            Console.WriteLine($"||         |     |          ||");
            Console.WriteLine($"||      {boardTally[0]}  |  {boardTally[1]}  |  {boardTally[2]}       ||");
            Console.WriteLine($"||    _____|_____|_____     ||");
            Console.WriteLine($"||         |     |          ||");
            Console.WriteLine($"||      {boardTally[3]}  |  {boardTally[4]}  |  {boardTally[5]}       ||");
            Console.WriteLine($"||    _____|_____|_____     ||");
            Console.WriteLine($"||         |     |          ||");
            Console.WriteLine($"||      {boardTally[0]}  |  {boardTally[1]}  |  {boardTally[2]}       ||");
            Console.WriteLine($"||         |     |          ||");
            Console.WriteLine($"\\|__________________________|/");
        }
    }
}
