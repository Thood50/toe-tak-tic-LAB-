using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	class Game
	{
		public Player PlayerOne { get; set; }
		public Player PlayerTwo { get; set; }
		public Player Winner { get; set; }
		public Board Board { get; set; }


		/// <summary>
		/// Require 2 players and a board to start a game. 
		/// </summary>
		/// <param name="p1">Player 1</param>
		/// <param name="p2">Player 2</param>
		public Game(Player p1, Player p2)
		{
			PlayerOne = p1;
			PlayerTwo = p2;
			Board = new Board();
		}

		/// <summary>
		/// Activate the Play of the game
		/// </summary>
		/// <returns>Winner</returns>
		public Player Play()
		{
            Player Draw = new Player();
            Draw.Name = "Its a draw!";
            int turnCount = -1;
            
            
            while (CheckForWinner(Board) == false && turnCount < 11)
            {
                turnCount++;
                string nextTurn = "0";
                if (PlayerOne.IsTurn == true)
                {
                    Console.WriteLine($"Okay {PlayerOne.Name}, your turn");
                    nextTurn = Console.ReadLine();

                }
                if (PlayerTwo.IsTurn == true)
                {
                    Console.WriteLine($"Okay {PlayerTwo.Name}, your turn");
                    nextTurn = Console.ReadLine();
                }

                int rows = Board.GameBoard.GetLength(0);
                int cols = Board.GameBoard.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        if (nextTurn == Board.GameBoard[i, k])
                        {
                            if (PlayerOne.IsTurn == true)
                            {
                                Board.GameBoard[i, k] = "X";
                            }
                            if (PlayerTwo.IsTurn == true)
                            {
                                Board.GameBoard[i, k] = "O";
                            }
                        }
                    }
                }
                Board.DisplayBoard();
                if (turnCount == 10)
                {
                    Winner = Draw;
                    return Winner;
                }

                SwitchPlayer();
                NextPlayer();               
            }
            return Winner;
		}


		/// <summary>
		/// Check if winner exists
		/// </summary>
		/// <param name="board">current state of the board</param>
		/// <returns>if winner exists</returns>
		public bool CheckForWinner(Board board)
		{
			int[][] winners = new int[][]
			{
				new[] {1,2,3},
				new[] {4,5,6},
				new[] {7,8,9},

				new[] {1,4,7},
				new[] {2,5,8},
				new[] {3,6,9},

				new[] {1,5,9},
				new[] {3,5,7}
			};

            

			// Given all the winning conditions, Determine the winning logic. 
			for (int i = 0; i < winners.Length; i++)
			{
				Position p1 = Player.PositionForNumber(winners[i][0]);
				Position p2 = Player.PositionForNumber(winners[i][1]);
				Position p3 = Player.PositionForNumber(winners[i][2]);

				string a = Board.GameBoard[p1.Row, p1.Column];
				string b = Board.GameBoard[p2.Row, p2.Column];
				string c = Board.GameBoard[p3.Row, p3.Column];


                
                
				
				// return true if a winner has been reached. 
                if (a == b && b == c && c == a)
                {
                    if (b == "X")
                    {
                        Winner = PlayerOne;
                        return true;
                    }
                    if (b == "O")
                    {
                        Winner = PlayerTwo;
                        return true;
                    }
                }
              
			
			}

			return false;
		}


		/// <summary>
		/// Determine next player
		/// </summary>
		/// <returns>next player</returns>
		public Player NextPlayer()
		{
			return (PlayerOne.IsTurn) ? PlayerOne : PlayerTwo;
		}

		/// <summary>
		/// End one players turn and activate the other
		/// </summary>
		public void SwitchPlayer()
		{
			if (PlayerOne.IsTurn)
			{
              
				PlayerOne.IsTurn = false;

              
				PlayerTwo.IsTurn = true;
			}
			else
			{
				PlayerOne.IsTurn = true;
				PlayerTwo.IsTurn = false;
			}
		}


	}
}
