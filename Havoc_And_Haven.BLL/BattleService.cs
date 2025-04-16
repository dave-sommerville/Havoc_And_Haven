
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

        public List<Users> GetHeroes() {
            return _repo.GetHeroes();
        }

        public List<Users> GetVillains() {
            return _repo.GetVillains();
        }

        public List<Users> GetUsersByIds(List<int> ids) {
            return _repo.GetUsersByIds(ids);
        }
    }

}
