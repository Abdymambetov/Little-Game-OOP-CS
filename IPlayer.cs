namespace RockPaperScissorsGame
{
    public interface IPlayer
    {
        Move Move { get; }
        void MakeMove();
        Result CheckResult(IPlayer opponent);
    }
}
