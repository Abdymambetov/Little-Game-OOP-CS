using System;
using RockPaperScissorsGame;


namespace RockPaperScissors{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Welcome to Rock Paper Scissors Game!");
            Console.Write("Enter number of rounds: ");
            int rounds = Convert.ToInt32(Console.ReadLine());

            IPlayer player = new HumanPlayer();
            IPlayer computer = new ComputerPlayer();

            Game game = new Game(rounds, player, computer);
            game.Start();
        }
    }
}
