namespace Mission10.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }

        IEnumerable<Team> Teams { get; }

        Team GetTeamById(int? teamId);
    }
}
