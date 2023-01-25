using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    public class Supporter
    {
        // method to print out the board
        public void printBoard(string[,] board)
        {
            Console.WriteLine("\n " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2]);
            Console.WriteLine("------------");
            Console.WriteLine(" " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2]);
            Console.WriteLine("------------");
            Console.WriteLine(" " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + "\n");
        }

        // method to check the board for wins
        public bool checkWin(string[,] board, bool gameOver = false)
        { 
            for (int i = 0; i < board.Rank; i++)
            {
                // horizontal checks
                if ((board[i,0] != " ") && (board[i,0].Equals(board[i, 1])) && (board[i, 0].Equals(board[i, 2])))
                {
                    gameOver = true;
                    DetermineWinner(board, i, "horizontal");
                    return gameOver;
                }

                // vertical checks
                if ((board[0, i] != " ") && (board[0, i].Equals(board[1, i])) && (board[0, i].Equals(board[2, i])))
                    {
                        DetermineWinner(board, i, "vertical");
                        gameOver = true;
                        return gameOver;
                    }

                // down diagonal
                if ((board[0, 0] != " ") && (board[0, 0].Equals(board[1, 1])) && (board[0, 0].Equals(board[2, 2])))
                {
                    DetermineWinner(board, i, "down");
                    gameOver = true;
                    return gameOver;
                }

                // up diagnoal
                if ((board[0, 0] != " ") && (board[0, 2].Equals(board[1, 1])) && (board[0, 2].Equals(board[2, 0])))
                {
                    DetermineWinner(board, i, "up");
                    gameOver = true;
                    return gameOver;
                }
            }
            return gameOver;
            
        }

        // determines who the winner is
        void DetermineWinner(string[,] board, int location, string direction)
        {
            string winner = "";
            if (direction == "horizontal")
            {
                winner = board[0, location];
                Console.WriteLine("Congrations to Player " + winner + "! You won");
            }
            else if (direction == "vertical")
            {
                winner = board[location, 0];
                Console.WriteLine("Congrations to Player " + winner + "! You won");
            }
            else if (direction == "down")
            {
                winner = board[0, 0];
                Console.WriteLine("Congrations to Player " + winner + "! You won");
            }
            else
            {
                winner = board[0, 2];
                Console.WriteLine("Congrations to Player " + winner + "! You won");
            }

        }
        
        // method for printing out when the game is tied
        public bool tieGame(bool gameOver)
        {
            Console.WriteLine("The game has resulted in a tie.");
            return gameOver = true;
        }
    }
}
