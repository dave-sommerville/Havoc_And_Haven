namespace Havoc_And_Haven.Models
{
    // This will be used for personal information as well as what is public. This view will also provide access for users to edit their information, 
    // Find a new home base, or navigate to the crisis event creation page battle logic whatever 
    public class PrivateProfileVM
    {
        public int UserId { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string OriginStory { get; set; }
        public string Role { get; set; } // Could also be an Enum
        public int PowerLevel { get; set; }

        // Headquarters Info (if Hero)
        public int? HeadquartersId { get; set; }
        public string HeadquarterTitle { get; set; }
        public string HeadquarterDescription { get; set; }
        public int? HeadquarterCapacity { get; set; }
        public string HeadquarterLocation { get; set; }

        // Lair Info (if Villain)
        public int? LairId { get; set; }
        public string LairTitle { get; set; }
        public string LairDescription { get; set; }
        public int? LairCapacity { get; set; }
        public string LairLocation { get; set; }

        // Lists to show other users in the same base
        public List<string> OtherHeroesInHeadquarter { get; set; }
        public List<string> OtherVillainsInLair { get; set; }
    }
}
