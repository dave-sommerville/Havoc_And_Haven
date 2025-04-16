using Havoc_And_Haven.BLL;
using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;


namespace Havoc_And_Haven.Controllers
{
    public class LocationController : Controller
    {
        private readonly LocationService _LocationService;

        public LocationController ( LocationService locationservice)
        {
            
            _LocationService = locationservice;
        }
        public IActionResult Index()
        {
            List<Location> locations = _LocationService.GetAllLocations();
            return View(locations);
        }
    }
}
