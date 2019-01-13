using System;
using Lab04_TicTacToe.Classes;

namespace toe_tak_tic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to toe-tak-tic");
            Console.WriteLine("Who would like to be player One?");
            Player playerOne = new Player();
            playerOne.Name = Console.ReadLine();
            Console.WriteLine($"Who wants to play {playerOne.Name}");
            Player playerTwo = new Player();
            playerTwo.Name = Console.ReadLine();
            Game newGame = new Game(playerOne, playerTwo);
            Player winner = newGame.Play();
            if (winner.Name == "Its a draw!")
            {
                Console.WriteLine($"Sorry, {winner.Name}");
                Console.ReadLine();
            }
            Console.WriteLine($"Congrats {newGame.Play().Name}! You WON!");
            Console.ReadLine();
        }
    }
}
