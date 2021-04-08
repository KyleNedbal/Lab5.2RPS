using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RPS
{
    class PlayerRandom : Player
    {
        public PlayerRandom()
        {
            Name = "Player Random";
            Roshambo = GenerateRoshambo();
        }
        public override Roshambo GenerateRoshambo()
        {
            var random = new Random();
            return (Roshambo)random.Next(0, 3);
        }
    }
}
