using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RPS
{
    public abstract class Player
    {
        public Roshambo Roshambo { get; set; }
        public string Name { get; set; }

        public Player()
        {

        }
        public abstract Roshambo GenerateRoshambo();
    }
}
