namespace bowler.Models
{
    public interface IBowlingRepository
    {
        public IEnumerable<Bowler> Bowlers { get; }
        public IEnumerable<Team> Teams { get; }
        //bringing in the joined table function
        public IEnumerable<Bowler> GetJoinedTables();
    }
}
