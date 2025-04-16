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
            ViewBag.Locations = _crisisService.GetAllLocations();
            return View();
        }

        [HttpPost]
        public IActionResult Create(CrisisEvent crisisEvent)
        {
            if (ModelState.IsValid)
            {
                _crisisService.CreateCrisisEvent(crisisEvent);
                return RedirectToAction("Index");
            }

            ViewBag.Locations = _crisisService.GetAllLocations();
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

            ViewBag.Locations = _crisisService.GetAllLocations();
            return View(crisis);
        }

        [HttpPost]
        public IActionResult Edit(CrisisEvent crisisEvent)
        {
            if (ModelState.IsValid)
            {
                _crisisService.UpdateCrisisEvent(crisisEvent);
                return RedirectToAction("Index");
            } 

            ViewBag.Locations = _crisisService.GetAllLocations();
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
