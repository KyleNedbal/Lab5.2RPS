using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RPS
{
    class Rock : Player
    {
        public Rock()
        {
            Name = "Player Rock";
            Roshambo = GenerateRoshambo();
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }

    }
}
