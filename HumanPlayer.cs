using System;

namespace RockPaperScissorsGame
{
    public class HumanPlayer : IPlayer
    {
        public Move Move { get; private set; }

        public void MakeMove()
        {
            Console.WriteLine("Enter your move (1 - Rock, 2 - Paper, 3 - Scissors): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Move = (Move)(choice - 1);
        }

        public Result CheckResult(IPlayer opponent)
        {
            Move opponentMove = opponent.Move;
            if ((Move == Move.Rock && opponentMove == Move.Scissors) ||
                (Move == Move.Paper && opponentMove == Move.Rock) ||
                (Move == Move.Scissors && opponentMove == Move.Paper))
            {
                return Result.Win;
            }
            else if (Move == opponentMove)
            {
                return Result.Draw;
            }
            else
            {
                return Result.Lose;
            }
        }
    }
}
