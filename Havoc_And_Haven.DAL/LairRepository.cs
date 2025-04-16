using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havoc_And_Haven.Models;
using Microsoft.EntityFrameworkCore;

namespace Havoc_And_Haven.DAL
{
    public class LairRepository
    {
        private readonly HavocAndHavenDbContext _context;

        public LairRepository(HavocAndHavenDbContext context)
        {
            _context = context;
        }

        public List<Lair> GetAllLairs()
        {
            return _context.Lairs.ToList();
        }

        public Lair GetLairById(int id)
        {
            return _context.Lairs
                .Include(l => l.Location)
                .FirstOrDefault(l => l.LairId == id);
        }

        public void AddLair(Lair lair)
        {
            try
            {
                _context.Lairs.Add(lair);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving lair: {ex.Message}");
                throw;
            }
        }

        public void UpdateLair(Lair lair)
        {
            Lair? existingLair = _context.Lairs.Find(lair.LairId);
            if (existingLair != null)
            {
                Console.WriteLine($"Updating Lair {lair.LairId} in database.");

                existingLair.BaseTitle = lair.BaseTitle;
                existingLair.Capacity = lair.Capacity;
                existingLair.Description = lair.Description;

                _context.Lairs.Update(existingLair);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Lair not found for update.");
            }
        }

        public void DeleteLair(int lairId)
        {
            Lair? lair = _context.Lairs.Find(lairId);
            if (lair != null)
            {
                _context.Lairs.Remove(lair);
                _context.SaveChanges();
            }
        }
    }
}
