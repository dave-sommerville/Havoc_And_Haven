using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havoc_And_Haven.Models;
using Havoc_And_Haven.DAL;


namespace Havoc_And_Haven.DAL
{
    public class LocationRepository
    {
        private readonly HavocAndHavenDbContext _context;


        public LocationRepository(HavocAndHavenDbContext context)
        {
            _context = context;

        }
        public List<Locations> GetallLocations()
        {
            return _context.Locations.ToList();
        }
        public Location GetLocationbyId(int id)
        {
            return _context.Locations
                .FirstOrdefault(l.lairId == Id)
                .Include(l => l.locationId);

        }
        public void AddLocation(Location location)
        {
            try
            {
                _context.Locations.Add(location);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding Location :{ex.Message}");
                throw;
            }
        }
        public void UpdateLocation(Location location)
        {
            Location exsisting = _context.Locations.Find(location.LocationId);
            if (exsisting != null)
            {
                exsisting.LocationName = location.LocationName;
                exsisting.Description = location.Description;

                _context.Locations.Update(exsisting);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("The location was not found");
            }

        }
        public void Deletelocation(Location Location)
        {
            Location? _location = _context.Locations.Find(Id);
            if (Location != null)
            {
                _context.Locations.Remove(Location);
                _context.SaveChanges();
            }

        }
    }
}
