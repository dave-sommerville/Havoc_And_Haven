using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Havoc_And_Haven.DAL {
    public class BattleRepository {
        private readonly HavocAndHavenDbContext _context;

        public BattleRepository(HavocAndHavenDbContext context) {
            _context = context;
        }

        public List<Battle> GetAll() {
            return _context.Battles
                .Include(b => b.CrisisEvent)
                .Include(b => b.Hero)
                .Include(b => b.Villain)
                .ToList();
        }

        public Battle GetBattleById(int id) {
            return _context.Battles
                .Include(b => b.CrisisEvent) // If you're using navigation property
                .FirstOrDefault(b => b.BattleId == id);
        }

        public void Add(Battle battle) {
            _context.Battles.Add(battle);
            _context.SaveChanges();
        }

        public List<CrisisEvent> GetAllCrises() {
            return _context.CrisisEvents.ToList();
        }

        public void Delete(int id) {
            var battle = _context.Battles.Find(id);
            if (battle != null) {
                _context.Battles.Remove(battle);
                _context.SaveChanges();
            }
        }

        public List<Users> GetHeroes() {
            return _context.Users.Where(u => u.Role == "Hero").ToList();
        }

        public List<Users> GetVillains() {
            return _context.Users.Where(u => u.Role == "Villain").ToList();
        }

        public List<Users> GetUsersByIds(List<int> ids) {
            return _context.Users.Where(u => ids.Contains(u.UserId)).ToList();
        }
    }
}
