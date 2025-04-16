using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havoc_And_Haven.Models;
using Microsoft.EntityFrameworkCore;

namespace Havoc_And_Haven.DAL
{
    public class HeadquartersRepository
    {
        private readonly HavocAndHavenDbContext _context;

        public HeadquartersRepository(HavocAndHavenDbContext context)
        {
            _context = context;
        }

        public List<Headquarters> GetAllHeadquarters() { 
            return _context.Headquarters.ToList();
        }

        public Headquarters GetHeadquarterById(int id)
        {
            return _context.Headquarters
                .Include(r => r.Location)
                .FirstOrDefault(r => r.HeadquartersId == id);
        }

        public void AddHeadquarter(Headquarters headquarter)
        {
            try
            {
                _context.Headquarters.Add(headquarter);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving headquarter: {ex.Message}");
                throw;
            }
        }

        public void UpdateHeadquarters(Headquarters headquarter)
        {
            Headquarters? existingHeadquarter = _context.Headquarters.Find(headquarter.HeadquartersId);
            if (existingHeadquarter != null)
            {
                Console.WriteLine($"Updating Headquarter {headquarter.HeadquartersId} in database.");

                existingHeadquarter.BaseTitle = headquarter.BaseTitle;
                existingHeadquarter.Capacity = headquarter.Capacity;
                existingHeadquarter.Description = headquarter.Description;

                _context.Headquarters.Update(existingHeadquarter);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Headquarter not found for update.");
            }
        }

        public void DeleteHeadquarter(int HeadquartersId)
        {
            Headquarters? headquarters = _context.Headquarters.Find(HeadquartersId);
            if (headquarters != null)
            {
                _context.Headquarters.Remove(headquarters);
                _context.SaveChanges(); 
            }
        }
    }
}
