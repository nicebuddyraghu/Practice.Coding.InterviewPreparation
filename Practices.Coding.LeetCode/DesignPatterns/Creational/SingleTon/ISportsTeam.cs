namespace Practices.Coding.LeetCode.DesignPatterns.Creational
{
    interface ISportsTeam
    {
        string Name { get; }
        int TotalGamesWins { get; }
        int TotalGamesPlayed { get; }
        int TotalGamesLost { get; }
    }
}
