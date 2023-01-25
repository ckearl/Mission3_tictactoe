using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    class Driver
    {
        static void Main(string[] args)
        {
            // initialize the Supporter class
            var supporter = new Supporter();

            // populate the board for future checks
            string[,] board = new string[3,3];
            for (int i = 0; i < board.Rank + 1; i++) {
                for (int j = 0; j < board.Rank + 1; j++) {
                    board[i, j] = " ";
                }
            }

            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("This is your board. \nThe spaces are numbered columns 1-3, rows 1-3, from left to right, top to bottom.");

            Console.WriteLine("\n (3,1) | (3,2) | (3,3)");
            Console.WriteLine("----------------------");
            Console.WriteLine("\n (2,1) | (2,2) | (2,3)");
            Console.WriteLine("----------------------");
            Console.WriteLine("\n (1,1) | (1,2) | (1,3)\n");

            bool gameOver = false;
            string player = "";
            int turns = 1;
            int row = 0;
            int col = 0;
            bool availableSpace = true;

            while (gameOver == false)
            {
                // end game if there's a tie
                if (turns == 10)
                {
                    supporter.tieGame(gameOver);
                }

                // assign player for current turn
                if (turns % 2 == 0)
                {
                    player = "X";
                }
                else
                {
                    player = "O";
                }

                do
                {
                    // get a space from current player
                    Console.WriteLine("\nPlayer " + player + ", enter your row: ");
                    row = Convert.ToInt32(Console.ReadLine());
                    row = Math.Abs(row - 3);
                    Console.WriteLine("\nPlayer " + player + ", enter your column: ");
                    col = Convert.ToInt32(Console.ReadLine());
                    col = col - 1;

                    if (board[row, col] == " ")
                    {
                        board[row, col] = player;
                        availableSpace = true;
                        gameOver = supporter.checkWin(board, gameOver);
                    }
                    else
                    {
                        Console.WriteLine("\nThat position is filled try again"); // "That is an invalid choice. Please try again."
                    }

                } while (availableSpace == false);
                
                supporter.printBoard(board);
                turns++;
                
            }

            Console.WriteLine("\nThanks for playing!");
            

            /* logic for filling the spaces
            3,1 3,2 3,3
            2,1 2,2 2,3
            1,1 1,2 1,3

            col = enter - 1
            row = abs(enter - 3)

            0,0 0,1 0,2
            1,0 1,1 1,2
            2,0 2,1 2,2
            */
        }
    }
}
