using Microsoft.EntityFrameworkCore;

namespace bowler.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingContext _context;
        public EFBowlingRepository(BowlingContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
        public IEnumerable<Team> Teams => _context.Teams;

        // Way to create the joined table with include
        public IEnumerable<Bowler> GetJoinedTables()
        {
            var bowlersWithTeams = _context.Bowlers
                                  .Include(b => b.Team)
                                  .ToList();

            return bowlersWithTeams;
        }
    }
}
