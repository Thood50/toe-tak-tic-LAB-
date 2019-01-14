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
            Board testBoard = new Board();
            Assert.False(Game.CheckForWinner(testBoard));
        }

        [Fact]
        public void TestForWinner()
        {
            Board testBoard = new Board();
            testBoard.GameBoard[0, 0] = "X";
            testBoard.GameBoard[0, 1] = "X";
            testBoard.GameBoard[0, 2] = "X";
            Assert.True(Game.CheckForWinner(testBoard));
        }
        
    }
}
