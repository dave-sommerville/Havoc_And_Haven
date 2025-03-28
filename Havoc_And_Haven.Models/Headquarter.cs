namespace Havoc_And_Haven.Models
{
    public class Headquarter
    {
        public int HeadquarterID { get; set; }
        public string HeadquarterName { get; set; }
        public string HeadquarterTitle { get; set; }
        public DateTime DateRegistered { get; set; }
        public int LocationID { get; set; }
        public int Superhero { get; set; }
    }
}
