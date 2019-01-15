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
            bool isFalse = testGame.CheckForWinner(testGame.Board);
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
            bool isTrue = testGame.CheckForWinner(testGame.Board);
            Assert.True(isTrue);
        }

        [Fact]
        public void TestForPlayerTurn()
        {
            Player PlayerOne = new Player();
            Player PlayerTwo = new Player();            
            Board Board = new Board();
            Game testGame = new Game(PlayerOne, PlayerTwo);
            Assert.IsType<Player>(testGame.NextPlayer());
        }

        [Fact]
        public void TestForSwitchOfPlayerTurn()
        {
            Player PlayerOne = new Player();
            Player PlayerTwo = new Player();
            Board Board = new Board();
            Game testGame = new Game(PlayerOne, PlayerTwo);
            testGame.SwitchPlayer();
            Assert.IsType<Player>(testGame.NextPlayer());
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(9)]
        public void TestForValidPosition(int num)
        {                     
            Assert.IsType<Position>(Player.PositionForNumber(num));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        public void TestForNullPosition(int num)
        {
            Assert.Null(Player.PositionForNumber(num));
        }

    }
}
