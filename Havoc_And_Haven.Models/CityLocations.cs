namespace Havoc_And_Haven.Models
{
    public class CityLocations
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public string Coordinates { get; set; }
        public int? LairID { get; set; }
        public int? HeadquarterID { get; set; }
    }
}
