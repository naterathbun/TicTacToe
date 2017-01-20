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
        public string theWinner;
        public bool isTurnOver;
        public int nextPlayerIs;

        public Board()
        {
            player1Symbol = 'X';
            player2Symbol = 'O';
            isTurnOver = false;
            nextPlayerIs = 1;

            for (int i = 0; i < 9; i++)
            {
                boardTally.Add(' ');
            }
        }

        public void SetPlayerSymbols()
        {
            Console.WriteLine("Enter Symbol for Player 1: ");
            this.player1Symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Symbol for Player 2: ");
            this.player2Symbol = Convert.ToChar(Console.ReadLine());
        }

        public void AddPlayerSymbol()
        {
            int locationNum = 0;
            bool validInput = false;
            int player = GetNextPlayer();
            
            this.PrintBoard();
            Console.WriteLine($"Player {player}'s Turn: Choose an unoccupied square (by number):");
            while (!validInput)
            {
                int.TryParse(Console.ReadLine(), out locationNum);
                validInput = ((locationNum <= 9) && (locationNum > 0) && (boardTally[locationNum - 1] == ' '));
            }

            if (player == 1)
            {
                boardTally[locationNum - 1] = player1Symbol;
            }
            else
            {
                boardTally[locationNum - 1] = player2Symbol;
            }
            PrintBoard();
            isTurnOver = true;
        }

        public int GetNextPlayer()
        {
            int player;
            if (this.nextPlayerIs == 1)
            {
                player = this.nextPlayerIs;
                this.nextPlayerIs = 2;
            }
            else
            {
                player = this.nextPlayerIs;
                this.nextPlayerIs = 1;
            }
            return player;
        }

        public void NextTurn()
        {
            this.isTurnOver = false;
        }

        public void PrintBoard()
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

        public bool DidPlayerWin(int player)
        {
            char playerChar;
            if (player == 1)
            {
                playerChar = player1Symbol;
            }
            else
            {
                playerChar = player2Symbol;
            }
            if ((boardTally[0] == playerChar) && (boardTally[1] == playerChar) && (boardTally[2] == playerChar))
            {
                return true; // top row
            }
            else if ((boardTally[3] == playerChar) && (boardTally[4] == playerChar) && (boardTally[5] == playerChar))
            {
                return true; // middle row
            }
            else if ((boardTally[6] == playerChar) && (boardTally[7] == playerChar) && (boardTally[8] == playerChar))
            {
                return true; // bottom row
            }
            else if ((boardTally[0] == playerChar) && (boardTally[3] == playerChar) && (boardTally[6] == playerChar))
            {
                return true; // left col
            }
            else if ((boardTally[1] == playerChar) && (boardTally[4] == playerChar) && (boardTally[7] == playerChar))
            {
                return true; // middle col
            }
            else if ((boardTally[2] == playerChar) && (boardTally[5] == playerChar) && (boardTally[8] == playerChar))
            {
                return true; // right col
            }
            else if ((boardTally[2] == playerChar) && (boardTally[4] == playerChar) && (boardTally[6] == playerChar))
            {
                return true; // bottom left to top right
            }
            else if ((boardTally[0] == playerChar) && (boardTally[4] == playerChar) && (boardTally[8] == playerChar))
            {
                return true; // top left to bottom rgiht
            }
            return false;
        }

        public bool IsThereATie()
        {
            foreach (char tieChar in boardTally)
            {
                if (tieChar != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsTheGameOver()
        {

            if (DidPlayerWin(1))
            {
                theWinner = "Player 1 is the winner!!!";
                return true;
            }
            if (DidPlayerWin(2))
            {
                theWinner = "Player 2 is the winner!!!";
                return true;
            }
            if (IsThereATie())
            {
                theWinner = "It's a tie, no one wins!!!";
                return true;
            }
            return false;
        }

        public void DeclareWinner()
        {
            Console.WriteLine(this.theWinner);
            Console.ReadLine();
        }
    }
}
