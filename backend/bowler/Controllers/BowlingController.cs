using bowler.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bowler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _repo;

        public BowlingController(IBowlingRepository repo)
        {
            _repo = repo;
        }

        // Returns the joined table at api/Bowling/GetJoinedTables
        [HttpGet("GetJoinedTables")]
        public IEnumerable<Bowler> GetJoinedTables()
        {
            var bowlers = _repo.GetJoinedTables()
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"); 
            
            return bowlers;
        }
    }
}
