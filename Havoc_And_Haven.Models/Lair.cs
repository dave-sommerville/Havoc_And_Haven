namespace Havoc_And_Haven.Models
{
    public class Lair
    {
        public int LairId { get; set; }
        public string BaseTitle { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public Location? Location { get; set; }
        public List<User> Villains { get; set; } = new List<User>();
    }
}
