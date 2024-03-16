using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10.Data;

namespace Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingController(IBowlingRepository temp)
        {
            _bowlingRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var teamData = _bowlingRepository.Bowlers
     .Where(bowler => {
         var teamName = _bowlingRepository.GetTeamById(bowler.TeamId).TeamName;
         return teamName == "Sharks" || teamName == "Marlins";
     })
     .ToList(); // To force execution and avoid multiple calls to GetTeamById
            return teamData;
        }
    }
}
