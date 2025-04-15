using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havoc_And_Haven.DAL;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.BLL
{
    public class LairService
    {
        private readonly LairRepository _lairRepository;

        public LairService(LairRepository lairRepository)
        {
            _lairRepository = lairRepository;
        }

        public List<Lair> GetAllLairs()
        {
            return _lairRepository.GetAllLairs();
        }

        public Lair GetLairById(int lairId)
        {
            return _lairRepository.GetLairById(lairId);
        }

        public void AddLair(Lair Lair)
        {
            Console.WriteLine($"Registering headquarter: {Lair.BaseTitle}");
            _lairRepository.AddLair(Lair);
        }

        public void UpdateLair(Lair Lair)
        {
            _lairRepository.UpdateLair(Lair);
        }

        public void DeleteLair(int LairId)
        {
            _lairRepository.DeleteLair(LairId);
        }
    }
}
