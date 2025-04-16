using Havoc_And_Haven.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Havoc_And_Haven.DAL
{
    public class CrisisEventRepository
    {
        private readonly HavocAndHavenDbContext _context;

        public CrisisEventRepository(HavocAndHavenDbContext context)
        {
            _context = context;
        }

        public List<CrisisEvent> GetAll()
        {
            return _context.CrisisEvents
                .Include(c => c.Location)
                //.Include(c => c.Heroes)
                //.Include(c => c.Villains)
                .ToList();
        }

        public CrisisEvent GetById(int id)
        {
            return _context.CrisisEvents
                .Include(c => c.Location)
                .Include(c => c.Heroes)
                .Include(c => c.Villains)
                .FirstOrDefault(c => c.CrisisId == id);
        }

        public void Add(CrisisEvent crisis)
        {
            _context.CrisisEvents.Add(crisis);
            _context.SaveChanges();
        }

        public void Update(CrisisEvent crisis)
        {
            CrisisEvent existingCrisis = _context.CrisisEvents.FirstOrDefault(c => c.CrisisId == crisis.CrisisId);
            if (existingCrisis != null) {
                existingCrisis.Title = crisis.Title;
                existingCrisis.CreatedAt = crisis.CreatedAt;
                existingCrisis.LocationId = crisis.LocationId;
                existingCrisis.IsResolved = crisis.IsResolved;
                _context.SaveChanges();
            }
            //_context.CrisisEvents.Update(crisis);
            //_context.SaveChanges();
        }

        public void Delete(int id)
        {
            var crisisEvent = _context.CrisisEvents.Find(id);
            if (crisisEvent != null)
            {
                _context.CrisisEvents.Remove(crisisEvent);
                _context.SaveChanges();
            }
        }

        public List<Users> GetHeroes()
        {
            return _context.Users.Where(u => u.Role == "Hero").ToList();
        }

        public List<Users> GetVillains()
        {
            return _context.Users.Where(u => u.Role == "Villain").ToList();
        }

        public List<Location> GetAllLocations()
        {
            return _context.Locations.ToList();
        }

        public List<Users> GetUsersByIds(List<int> ids)
        {
            return _context.Users.Where(u => ids.Contains(u.UserId)).ToList();
        }
    }
}
