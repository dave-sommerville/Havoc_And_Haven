using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havoc_And_Haven.DAL;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.BLL {
    public class CrisisEventService {
        private readonly CrisisEventRepository _repo;

        public CrisisEventService(CrisisEventRepository repo) {
            _repo = repo;
        }

        public void CreateCrisis(CrisisEvent crisisEvent) {
            if (crisisEvent == null) {
                throw new ArgumentNullException(nameof(crisisEvent));
            }
            _repo.Add(crisisEvent);
        }

        public List<CrisisEvent> GetAllCrises() {
            return _repo.GetAll();
        }

        public CrisisEvent GetCrisisById(int id) {
            return _repo.GetById(id);
        }

        public void UpdateCrisis(CrisisEvent crisisEvent) {
            if (crisisEvent.CrisisId <= 0) {
                throw new ArgumentException("Invalid crisis ID.");
            }
            _repo.Update(crisisEvent);
        }

        public void DeleteCrisis(int id) {
            _repo.Delete(id);
        }

        public List<User> GetHeroes() {
            return _repo.GetHeroes();
        }

        public List<User> GetVillains() {
            return _repo.GetVillains();
        }

        public List<Location> GetAllLocations() {
            return _repo.GetAllLocations();
        }

        public List<User> GetUsersByIds(List<int> ids) {
            return _repo.GetUsersByIds(ids);
        }
    }
}
