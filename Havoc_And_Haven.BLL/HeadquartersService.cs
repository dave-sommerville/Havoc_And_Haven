using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havoc_And_Haven.DAL;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.BLL
{
    public class HeadquartersService
    {
        private readonly HeadquartersRepository _headquartersRepository;

        public HeadquartersService(HeadquartersRepository headquartersRepository)
        {
            _headquartersRepository = headquartersRepository;
        }

        public List<Headquarters> GetAllHeadquarters()
        {
            return _headquartersRepository.GetAllHeadquarters();
        }

        public Headquarters GetHeadquarterById(int headquarterId)
        {
            return _headquartersRepository.GetHeadquarterById(headquarterId);
        }

        public void AddHeadquarter(Headquarters headquarter)
        {
            Console.WriteLine($"Registering headquarter: {headquarter.BaseTitle}");
            _headquartersRepository.AddHeadquarter(headquarter);
        }

        public void UpdateHeadquarters(Headquarters headquarter)
        {
            _headquartersRepository.UpdateHeadquarters(headquarter);
        }

        public void DeleteHeadquarter(int HeadquartersId)
        {
            _headquartersRepository.DeleteHeadquarter(HeadquartersId);
        }
    }
}
