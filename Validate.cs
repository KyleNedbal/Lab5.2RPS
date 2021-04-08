using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RPS
{
    class Validate
    {
        public Validate()
        {

        }
        public string PlayerVS()
        {
            string input;
            do
            {
                Console.WriteLine("Who would you like to play against?\n" +
                    "(1)Player Rock - Roshambo Value = PlayerRock\n" +
                    "(2)Player Random - Roshambo Value = Random");
                input = Console.ReadLine();
            } while (!(input == "1" || input == "2"));
            return input;
        }
        public string RPS()
        {
            string input;
            do
            {
                Console.WriteLine("Rock, Paper, Scissors? (R/P/S)");
                input = Console.ReadLine().ToUpper();
            } while (!(input == "R" || input == "P" || input == "S"));
            return input;
        }
    }
}
