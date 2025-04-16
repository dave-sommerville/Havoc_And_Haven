using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havoc_And_Haven.DAL;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.BLL
{
    public class LocationService
    {
        private readonly LocationRepository _repo;

        public LocationService(LocationRepository repo)
        {
            _repo = repo;
        }
        public List<Location> GetAllLocations()
        {
            return _repo.GetallLocations();
        }

        public Location? GetLocationById(int Id)
        {
            return _repo.GetLocationById(Id);
        }
        public void Create(Location location) {
            _repo.AddLocation(location);
        }
        public void Edit(Location location)
        {
            _repo.UpdateLocation(location);
        }

        public void delete(int Id)
        {
            _repo.Deletelocation(Id);
        }
    }
}