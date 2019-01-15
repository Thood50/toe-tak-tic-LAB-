using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using toe_tak_tic;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestForLoser()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Board Board = new Board();
            Game testGame = new Game(playerOne, playerTwo);            
            bool isFalse = CheckForWinner(testGame.Board)
            Assert.False(isFalse);
        }

        [Fact]
        public void TestForWinner()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Board Board = new Board();
            Game testGame = new Game(playerOne, playerTwo);
            testGame.Board.GameBoard[0, 0] = "X";
            testGame.Board.GameBoard[0, 1] = "X";
            testGame.Board.GameBoard[0, 2] = "X";
            bool isTrue = CheckForWinner(testGame.Board)
            Assert.True(isTrue);
        }
        
    }
}
