using System;

namespace RockPaperScissorsGame
{
    public class ComputerPlayer : IPlayer
    {
        private Random random;

        public Move Move { get; private set; }

        public ComputerPlayer()
        {
            random = new Random();
        }

        public void MakeMove()
        {
            Move = (Move)random.Next(0, 3);
        }

        public Result CheckResult(IPlayer opponent)
        {
            return opponent.CheckResult(this) switch
            {
                Result.Win => Result.Lose,
                Result.Lose => Result.Win,
                _ => Result.Draw
            };
        }
    }
}
