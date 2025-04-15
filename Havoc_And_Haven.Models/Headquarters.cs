namespace Havoc_And_Haven.Models
{
    public class Headquarters
    {
        public int HeadquartersId { get; set; }
        public string BaseTitle { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public Location? Location { get; set; }
        public List<Users> Heroes { get; set; } = new List<Users>();
    }
}
