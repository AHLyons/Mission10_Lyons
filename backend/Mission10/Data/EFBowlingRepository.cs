using Mission10.Data;

namespace Mission10.Data
{
    public class EFBowlingRepository: IBowlingRepository
    {
        private BowlingLeagueContext _bowlingContext;
        public EFBowlingRepository(BowlingLeagueContext temp) { 
            _bowlingContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlingContext.Bowlers;

        public IEnumerable<Team> Teams => _bowlingContext.Teams;

        public Team GetTeamById(int? teamId)
        {
            return _bowlingContext.Teams.Find(teamId);
        }
    }
}