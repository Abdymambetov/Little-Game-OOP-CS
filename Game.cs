using System;

namespace RockPaperScissorsGame
{
    public class Game
    {
        private IPlayer player;
        private IPlayer computer;
        private int rounds;

        public Game(int rounds, IPlayer player, IPlayer computer)
        {
            this.rounds = rounds;
            this.player = player;
            this.computer = computer;
        }

        public void Start()
        {
            for (int i = 0; i < rounds; i++)
            {
                player.MakeMove();
                computer.MakeMove();

                Console.WriteLine($"Player's move: {player.Move}");
                Console.WriteLine($"Computer's move: {computer.Move}");

                Result result = player.CheckResult(computer);
                Console.WriteLine($"Result: {result}");

                if (result == Result.Win)
                {
                    Console.WriteLine("You win this round!");
                }
                else if (result == Result.Lose)
                {
                    Console.WriteLine("Computer wins this round!");
                }
                else
                {
                    Console.WriteLine("It's a draw!");
                }
            }
        }
    }
}
