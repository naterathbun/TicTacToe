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
        //public string humanOrAI;
        public bool isTurnOver;

        public Board()                                  // blank the board
        {
            player1Symbol = 'X';
            player2Symbol = 'O';
            isTurnOver = false;

            for (int i = 0; i < 9; i++)
            {
                boardTally.Add(' ');
            }
        }

        public void AddPlayer1Symbol()
        {
            int locationNum = 0;
            bool validInput = false;

            while (!validInput)
            {
                int.TryParse(Console.ReadLine(),out locationNum);
                validInput = ((locationNum <= 9) && (locationNum >= 0) && (boardTally[locationNum] == ' '));
            }

            boardTally[locationNum - 1] = player1Symbol;
            isTurnOver = true;
        }

        public void AddPlayer2Symbol()
        {
            int locationNum = 0;
            bool validInput = false;

            while (!validInput)
            {
                int.TryParse(Console.ReadLine(), out locationNum);
                validInput = ((locationNum <= 9) && (locationNum >= 0) && (boardTally[locationNum] == ' '));
            }

            boardTally[locationNum - 1] = player2Symbol;
            isTurnOver = true;
        }

        public void NextTurn()
        {
            this.isTurnOver = false;
        }
        
        public void printBoard()
        {
            Console.Clear();
            Console.WriteLine($"\n   __________________________");
            Console.WriteLine($" /|                          |\\");
            Console.WriteLine($" ||    1    |2    |3         ||\\_____________________");
            Console.WriteLine($" ||      {this.boardTally[0]}  |  {this.boardTally[1]}  |  {this.boardTally[2]}       ||                     |\\");
            Console.WriteLine($" ||    _____|_____|_____     ||                     ||");
            Console.WriteLine($" ||    4    |5    |6         ||     Player 1:  {this.player1Symbol}    ||");
            Console.WriteLine($" ||      {this.boardTally[3]}  |  {this.boardTally[4]}  |  {this.boardTally[5]}       ||                     ||");
            Console.WriteLine($" ||    _____|_____|_____     ||     Player 2:  {this.player2Symbol}    ||");
            Console.WriteLine($" ||    7    |8    |9         ||                     ||");
            Console.WriteLine($" ||      {this.boardTally[6]}  |  {this.boardTally[7]}  |  {this.boardTally[8]}       || ____________________|/");
            Console.WriteLine($" ||         |     |          ||/");
            Console.WriteLine($" \\|__________________________|/\n");
        }
    }
}
