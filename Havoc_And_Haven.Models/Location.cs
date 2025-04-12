namespace Havoc_And_Haven.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Type { get; set; } // e.g.Power plant, city bank, etc.
        public string Neighborhood { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public List<CrisisEvent> CrisisEvents { get; set; } = new List<CrisisEvent>();
    }
}
