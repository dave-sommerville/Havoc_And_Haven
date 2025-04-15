namespace Havoc_And_Haven.Models
{
    public class CrisisEvent
    {
        public int CrisisId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        // The mechanics of the crisis events and battles will need to be refined 
        public  ICollection<Users>? Villains { get; set; }
        public  ICollection<Users>? Heroes { get; set; }
        public bool IsResolved { get; set; } = false; // I think this is redundant 
        public int LocationId { get; set; }
        public Location Location { get; set; }
        //public Battle ResultingBattle { get; set; }
    }
}
