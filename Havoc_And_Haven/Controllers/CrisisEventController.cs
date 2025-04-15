using Havoc_And_Haven.BLL;
using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Havoc_And_Haven.Controllers
{
    public class CrisisEventController : Controller
    {
        private readonly CrisisEventService _crisisService;

        public CrisisEventController(CrisisEventService crisisService)
        {
            _crisisService = crisisService;
        }

        public IActionResult Index()
        {
            List<CrisisEvent> crises = _crisisService.GetAllCrisisEvents();
            return View(crises);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Locations = new SelectList(_crisisService.GetAllLocations(), "LocationId", "Neighborhood");
            ViewBag.Heroes = _crisisService.GetHeroes();
            ViewBag.Villains = _crisisService.GetVillains();
            return View();
        }

        [HttpPost]
        public IActionResult Create(CrisisEvent crisisEvent, List<int> SelectedHeroes, List<int> SelectedVillains)
        {
            if (ModelState.IsValid)
            {
                crisisEvent.Heroes = _crisisService.GetUsersByIds(SelectedHeroes);
                crisisEvent.Villains = _crisisService.GetUsersByIds(SelectedVillains);

                _crisisService.CreateCrisisEvent(crisisEvent);
                return RedirectToAction("Index");
            }

            ViewBag.Locations = new SelectList(_crisisService.GetAllLocations(), "LocationId", "Neighborhood");
            ViewBag.Heroes = _crisisService.GetHeroes();
            ViewBag.Villains = _crisisService.GetVillains();
            return View(crisisEvent);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            CrisisEvent crisis = _crisisService.GetCrisisEventById(id);
            if (crisis == null)
            {
                return Content("Not Found");
            }

            ViewBag.Locations = new SelectList(_crisisService.GetAllLocations(), "LocationId", "Neighborhood", crisis.LocationId);
            ViewBag.Heroes = _crisisService.GetHeroes();
            ViewBag.Villains = _crisisService.GetVillains();
            return View(crisis);
        }

        [HttpPost]
        public IActionResult Edit(CrisisEvent crisisEvent, List<int> SelectedHeroes, List<int> SelectedVillains)
        {
            if (ModelState.IsValid)
            {
                crisisEvent.Heroes = _crisisService.GetUsersByIds(SelectedHeroes);
                crisisEvent.Villains = _crisisService.GetUsersByIds(SelectedVillains);

                _crisisService.UpdateCrisisEvent(crisisEvent);
                return RedirectToAction("Index");
            }

            ViewBag.Locations = new SelectList(_crisisService.GetAllLocations(), "LocationId", "Neighborhood", crisisEvent.LocationId);
            ViewBag.Heroes = _crisisService.GetHeroes();
            ViewBag.Villains = _crisisService.GetVillains();
            return View(crisisEvent);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            CrisisEvent crisis = _crisisService.GetCrisisEventById(id);
            if (crisis != null)
            {
                _crisisService.DeleteCrisisEvent(id);
                return RedirectToAction("Index");
            }
            return Content("Not found!");
        }

        public IActionResult Detail(int id)
        {
            CrisisEvent crisis = _crisisService.GetCrisisEventById(id);
            if (crisis == null)
            {
                return Content("Not Found");
            }
            return View(crisis);
        }
    }
}
