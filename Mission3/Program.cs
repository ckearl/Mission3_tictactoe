using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    class Main
    {
        static void Main(string[] args)
        {
            var supporter = new Supporter();
            string[,] board = new string[3,3];
            for (int i = 0; i < board.Rank + 1; i++) {
                for (int j = 0; j < board.Rank + 1; j++) {
                    board[i, j] = " ";
                }
            }



            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("This is your board. \n The spaces are numbered columns 1-3, rows 1-3, from left to right, top to bottom.");

            Console.WriteLine("\n " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2] + " | ");
            Console.WriteLine("------------");
            Console.WriteLine(" " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + " | ");
            Console.WriteLine("------------");
            Console.WriteLine(" " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + " | \n");

            bool gameOver = false;
            string player = "X";
            int turns = 0;
            while (GameOver == false)
            {
                supporter.printboard(board);

                Console.WriteLine("Enter your row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your column: ");
                int col = Convert.ToInt32(Console.ReadLine());

                if (board[row, col] == " ")
                {
                    board[row, col] = Player;
                    Player = "O"; //Need to change this, won't work when it is O's turn
                    supporter.checkWin(board, GameOver);
                }
                else
                {
                    Console.WriteLine("That position is filled try again"); // "That is an invalid choice. Please try again."
                }
                
            }





            // while ((board[0, 0] == board[0, 1] == board[0, 2]) && (board[1, 0] == board[1, 1] == board[1, 2]) && (board[2, 0] == board[2, 1] == board[2, 2]))
            /* {
                
            }*/
        }
    }
}
