using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RPS
{
    class User : Player
    {
        public User()
        {
            Name = GetName();
        }

        public string GetName()
        {
            Console.Write("What is your name?: ");
            return Console.ReadLine();
        }
        public override Roshambo GenerateRoshambo()
        {
            var input = new Validate().RPS();

            if (input == "R")
            {
                Roshambo = Roshambo.Rock;
                return Roshambo.Rock;
            }
            else if (input == "P")
            {
                Roshambo = Roshambo.Paper;
                return Roshambo.Paper;
            }
            else
            {
                Roshambo = Roshambo.Scissors;
                return Roshambo.Scissors;
            }
        }
    }
}
