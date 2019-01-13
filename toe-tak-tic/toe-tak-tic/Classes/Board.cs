using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{

            //TODO: Output the board to the console
            int rows = GameBoard.GetLength(0);
            int cols = GameBoard.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (k == 2)
                    {
                        Console.WriteLine($" {GameBoard[i, k]} ");
                    }
                    if (k < 2)
                    {
                        Console.Write($" {GameBoard[i, k]} |");
                    }
                }
            }

        }
	}
}
