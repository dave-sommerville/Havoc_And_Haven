
using Havoc_And_Haven.DAL;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.BL
{
    public class BattleService
    {
        private readonly BattleRepository _repo;

        public BattleService(BattleRepository repo) {
            _repo = repo;
        }

        public List<Battle> GetAllBattles() {
            return _repo.GetAll();
        }

        public void CreateBattle(Battle battle) {
            _repo.Add(battle);
        }

        public List<CrisisEvent> GetAllCrises() {
            return _repo.GetAllCrises();
        }
    }

}
