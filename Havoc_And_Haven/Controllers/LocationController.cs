using Havoc_And_Haven.BLL;
using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;


namespace Havoc_And_Haven.Controllers
{
    public class LocationController : Controller
    {
        private readonly LocationService _LocationService;

        public LocationController(LocationService locationservice)
        {

            _LocationService = locationservice;
        }

        public IActionResult Index()
        {
            List<Location> locations = _LocationService.GetAllLocations();
            return View(locations);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Location());
        }

        [HttpPost]
        public IActionResult Create(Location location)
        {
            if (ModelState.IsValid)
            {
                _LocationService.Create(location);
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View(new Location());
        }

        [HttpPost]
        public IActionResult Edit(Location location)
        {
            if (ModelState.IsValid)
            {
                _LocationService.Edit(location);
                return RedirectToAction("Index");
            }

            return View(location);
        }

        [HttpGet]
        public IActionResult DeleteLocation(int id)
        {
            Location? location = _LocationService.GetLocationById(id);
            return View(location);
        }

        [HttpPost]
        public IActionResult DeleteLocationConfirmed(int id)
        {
            Location? location = _LocationService.GetLocationById(id);
            if (location == null)
            {
                return NotFound();
            }

            _LocationService.delete(id);

            return RedirectToAction("Index");
        }
    }
}
    