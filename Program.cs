using System;

namespace Lab5._2RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!\n");

            var playGame = new RoshamboApp();
            int wins = 0, losses = 0, draw = 0, temp;
            var player = new User();

            do
            {
                temp = playGame.PlayGame(player);
                if (temp == 1)
                {
                    wins++;
                }
                else if (temp == 2)
                {
                    losses++;
                }
                else
                {
                    draw++;
                }
                Console.WriteLine($"Wins: {wins}\n" +
                    $"Losses: {losses}\n" +
                    $"Draws: {draw}\n");

                Console.Write("Play again? (y/n): ");
            } while (Console.ReadLine().ToLower() == "y");
            Console.WriteLine("Thanks for playing!\n");
        }
    }
}
