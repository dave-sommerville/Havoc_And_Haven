using Havoc_And_Haven.DAL;
using Havoc_And_Haven.Models;
using System;
using System.Collections.Generic;

namespace Havoc_And_Haven.BLL
{
    public class CrisisEventService
    {
        private readonly CrisisEventRepository _crisisEventRepository;

        public CrisisEventService(CrisisEventRepository crisisEventRepository)
        {
            _crisisEventRepository = crisisEventRepository;
        }

        public List<CrisisEvent> GetAllCrisisEvents()
        {
            return _crisisEventRepository.GetAll();
        }

        public CrisisEvent GetCrisisEventById(int id)
        {
            return _crisisEventRepository.GetById(id);
        }

        public void CreateCrisisEvent(CrisisEvent crisisEvent)
        {
            _crisisEventRepository.Add(crisisEvent);
        }

        public void UpdateCrisisEvent(CrisisEvent crisisEvent)
        {
            _crisisEventRepository.Update(crisisEvent);
        }

        public void DeleteCrisisEvent(int id)
        {
            _crisisEventRepository.Delete(id);
        }

        public List<Users> GetHeroes() {
            return _crisisEventRepository.GetHeroes();
        }

        public List<Users> GetVillains() {
            return _crisisEventRepository.GetVillains();
        }

        public List<Location> GetAllLocations()
        {
            return _crisisEventRepository.GetAllLocations();
        }

        public List<Users> GetUsersByIds(List<int> ids) {
            return _crisisEventRepository.GetUsersByIds(ids);
        }
    }
}
