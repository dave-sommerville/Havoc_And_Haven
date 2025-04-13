
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.BL
{
    public class BattleService
    {/*
        public async Task CheckAndTriggerBattle(CrisisEvent crisis)
        {
            if (crisis.IsResolved) return;

            bool enoughParticipants = crisis.Heroes.Count >= 3 && crisis.Villains.Count >= 3;
            bool oneHourPassed = (DateTime.Now - crisis.CreatedAt).TotalMinutes >= 60;

            if (enoughParticipants || oneHourPassed)
            {
                await TriggerBattle(crisis);
            }
        }

        public async Task TriggerBattle(CrisisEvent crisis)
        {
            var battle = new Battle
            {
                CrisisId = crisis.CrisisId,
                Heroes = crisis.Heroes.ToList(),
                Villains = crisis.Villains.ToList(),
                Winner = DecideWinner() // implement logic
            };

            crisis.IsResolved = true;
            crisis.ResultingBattle = battle;
            // Save battle and crisis update to DB
        }
       
        private string DecideWinner()
        {
            // Simple logic for now
            // This is where I would implement the user power levels
            return new Random().Next(0, 2) == 0 ? "Heroes" : "Villains";
        }
        */
    }

}
