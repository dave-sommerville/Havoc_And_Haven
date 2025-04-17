
namespace Havoc_And_Haven.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Alias { get; set; }
        public string OriginStory { get; set; }
        public string Role { get; set; }
        public int PowerLevel { get; set; }

        public int? HeadquartersId { get; set; }
        public Headquarters? Headquarters { get; set; }
        public int? LairId { get; set; }
        public Lair? Lair { get; set; }
    }
}
