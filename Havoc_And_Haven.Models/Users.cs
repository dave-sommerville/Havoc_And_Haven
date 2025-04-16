

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
        // This is possible aspect we could work into battle mechanics, but isn't needed 
        public int PowerLevel { get; set; }
        // Users may not immediately have a base, so these can be nullable, but they can have only one max
        public int? HeadquartersId { get; set; }
        public Headquarters Headquarters { get; set; }
        public int? LairId { get; set; }
        public Lair Lair { get; set; }

        public int? BattleId { get; set; }
        public Battle? battle { get; set; }
    }
}
