namespace Havoc_And_Haven.Models
{
    public class EmergencyCalls
    {
        public int Id { get; set; }
        public int DistressCode { get; set; }
        public string EmergencyDescription { get; set; }
        public int LocationID { get; set; }
        public int SuperheroID { get; set; }
        public int VillainID { get; set; }

    }
}
