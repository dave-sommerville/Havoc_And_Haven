using Havoc_And_Haven.BLL;
using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;

namespace Havoc_And_Haven.Controllers
{
    public class LairController : Controller {
        private readonly LairService _lairService;
        //private readonly LocationService _locationService;

        public LairController(LairService lairService) {
            _lairService = lairService;
            //_locationService = locationService;
        }

        public IActionResult Index() {
            List<Lair> lairs = _lairService.GetAllLairs();
            return View(lairs);
        }

        [HttpGet]
        public IActionResult AddLair() {
            //ViewBag.Locations = _locationService.GetAllLocation();

            return View(new Lair());
        }
        [HttpPost]
        public IActionResult AddLair(Lair lair) {
            if (ModelState.IsValid) {
                //lair.Location = _locationService.GetLocationById(lair.LocationId);

                _lairService.AddLair(lair);

                return RedirectToAction("Index");
            }

            //ViewBag.Locations = _locationService.GetAllLocation();
            return View(lair);
        }

        [HttpGet]
        public IActionResult UpdateHeadquarters(int id) {
            Lair? lair = _lairService.GetAllLairs().FirstOrDefault(r => r.LairId == id);
            if (lair == null) {
                return NotFound();
            }

            //ViewBag.Locations = _locationService.GetAllLocation();

            return View(lair);
        }

        [HttpPost]
        public IActionResult UpdateHeadquarters(Lair lair) {
            if (ModelState.IsValid) {
                _lairService.UpdateLair(lair);
                return RedirectToAction("Index");
            }

            //ViewBag.Locations = _locationService.GetAllLocation();

            return View(lair);
        }

        [HttpGet]
        public IActionResult DeleteHeadquarter(int id) {
            Lair? lair = _lairService.GetLairById(id);
            if (lair == null) {
                return NotFound();
            }

            return View(lair);
        }

        [HttpPost]
        public IActionResult DeleteHeadquarterConfirmed(int id) {
            Lair? lair = _lairService.GetLairById(id);
            if (lair == null) {
                return NotFound();
            }

            _lairService.DeleteLair(id);

            return RedirectToAction("Index");
        }
    }
}
