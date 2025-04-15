using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Havoc_And_Haven.DAL {
    public class BattleRepository {
        private readonly HavocAndHavenDbContext _context;

        public BattleRepository(HavocAndHavenDbContext context) {
            _context = context;
        }

        public List<Battle> GetAll()
        {
            return _context.Battles
                .Include(b => b.CrisisEvent)
                    .ThenInclude(ce => ce.Heroes)
                .Include(b => b.CrisisEvent)
                    .ThenInclude(ce => ce.Villains)
                .ToList();
        }


        public void Add(Battle battle) {
            _context.Battles.Add(battle);
            _context.SaveChanges();
        }

        public List<CrisisEvent> GetAllCrises() {
            return _context.CrisisEvents.ToList();
        }
    }
}
