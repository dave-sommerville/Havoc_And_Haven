namespace Havoc_And_Haven.Models
{
    public class Lair
    {
        public int LairID { get; set; }
        public string Title { get; set; }
        public DateTime DateRegistered { get; set; }
        public int LocationID { get; set; }
        public int VillainID { get; set; }
    }
}
