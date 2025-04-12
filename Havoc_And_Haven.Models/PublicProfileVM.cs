using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havoc_And_Haven.Models
{
    // This View model will be used to hide personal details of users, but allow all users to see their fellows users of that role
    public class PublicProfileVM
    {
        public string Alias { get; set; }
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

        // Optional: add lists if you want to show other users in the same base
        public List<string> OtherHeroesInHeadquarter { get; set; }
        public List<string> OtherVillainsInLair { get; set; }
    }
}
