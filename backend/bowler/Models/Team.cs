using System.ComponentModel.DataAnnotations;

namespace bowler.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }

    }
}
