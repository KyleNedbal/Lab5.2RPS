using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RPS
{
    class RoshamboApp
    {
        public RoshamboApp()
        {

        }
        public int PlayGame(User playerChoice)
        {
            var playerClass = new Validate().PlayerVS();

            playerChoice.GenerateRoshambo();

            if (playerClass == "1")
            {
                if (playerChoice.Roshambo == Roshambo.Rock)
                {
                    Console.WriteLine("Draw");
                    return 0;
                }
                else if (playerChoice.Roshambo == Roshambo.Paper)
                {
                    Console.WriteLine("You won");
                    return 1;
                }
                else
                {
                    Console.WriteLine("You lost");
                    return 2;
                }
            }
            else
            {
                var playerRandom = new PlayerRandom();
                if (playerChoice.Roshambo == Roshambo.Rock)
                {
                    if (playerRandom.Roshambo == Roshambo.Rock)
                    {
                        Console.WriteLine("Draw");
                        return 0;
                    }
                    else if (playerChoice.Roshambo == Roshambo.Paper)
                    {
                        Console.WriteLine("You lost");
                        return 2;
                    }
                    else
                    {
                        Console.WriteLine("You won");
                        return 1;
                    }
                }
                else if (playerChoice.Roshambo == Roshambo.Paper)
                {
                    if (playerRandom.Roshambo == Roshambo.Paper)
                    {
                        Console.WriteLine("Draw");
                        return 0;
                    }
                    else if (playerRandom.Roshambo == Roshambo.Scissors)
                    {
                        Console.WriteLine("You lost");
                        return 2;
                    }
                    else
                    {
                        Console.WriteLine("You won");
                        return 1;
                    }
                }
                else
                {
                    if (playerRandom.Roshambo == Roshambo.Scissors)
                    {
                        Console.WriteLine("Draw");
                        return 0;
                    }
                    else if (playerRandom.Roshambo == Roshambo.Rock)
                    {
                        Console.WriteLine("You lost");
                        return 2;
                    }
                    else
                    {
                        Console.WriteLine("You won");
                        return 1;
                    }
                }
            
            }
        }
    }
}
