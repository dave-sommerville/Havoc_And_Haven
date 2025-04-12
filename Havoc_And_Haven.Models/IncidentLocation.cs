namespace Havoc_And_Haven.Models
{
    public class IncidentLocation
    {
        public int IncidentId { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        //For reverse navigation
        public Battle Battle { get; set; }
        public int ClearanceTime { get; set; } // in minutes
    }
}
