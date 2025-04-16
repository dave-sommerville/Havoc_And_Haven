namespace Havoc_And_Haven.Models
{
    public class Battle
    {
        public int BattleId { get; set; }
        public DateTime IncidentBegan { get; set; }
        public string? Winner { get; set; } // "Heroes" or "Villains"
        public int CrisisId { get; set; }
        public CrisisEvent? CrisisEvent { get; set; }

    }
}
