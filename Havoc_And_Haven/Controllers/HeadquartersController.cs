using System.Collections.Generic;
using System.Linq;
using Havoc_And_Haven.BLL;
using Havoc_And_Haven.DAL;
using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Havoc_And_Haven.Controllers
{
    public class HeadquartersController : Controller
    {
<<<<<<< HEAD
        //private readonly HeadquartersService _headquartersService;
        //private readonly LocationService _locationService;

        //public HeadquartersController(HeadquartersService headquartersService, LocationService locationService)
        //{
        //    _headquartersService = headquartersService;
        //    _locationService = locationService;
        //}
=======
        private readonly HeadquartersService _headquartersService;
        //private readonly LocationService _locationService;

        public HeadquartersController(HeadquartersService headquartersService)
        {
            _headquartersService = headquartersService;
            //_locationService = locationService;
        }
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //public IActionResult Index()
        //{
        //    List<Headquarters> headquarters = _headquartersService.GetAllHeadquarters();
        //    return View(headquarters);
        //}

<<<<<<< HEAD
        //[HttpGet]
        //public IActionResult AddHeadquarter()
        //{
        //    ViewBag.Locations = _locationService.GetAllLocation();
=======
        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.Locations = _locationService.GetAllLocation();
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //    return View(new Headquarters());
        //}

<<<<<<< HEAD
        //[HttpPost]
        //public IActionResult AddHeadquarter(Headquarters headquarter)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        headquarter.Location = _locationService.GetLocationById(headquarter.LocationId);
=======
        [HttpPost]
        public IActionResult Create(Headquarters headquarter)
        {
            if (ModelState.IsValid)
            {
                //headquarter.Location = _locationService.GetLocationById(headquarter.LocationId);
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //        _headquartersService.AddHeadquarter(headquarter);

        //        return RedirectToAction("Index");
        //    }

<<<<<<< HEAD
        //    ViewBag.Locations = _locationService.GetAllLocation();
        //    return View(headquarter);
        //}

        //[HttpGet]
        //public IActionResult UpdateHeadquarters(int id)
        //{
        //    Headquarters? headquarter = _headquartersService.GetAllHeadquarters().FirstOrDefault(r => r.HeadquartersId == id);
        //    if (headquarter == null)
        //    {
        //        return NotFound();
        //    }

        //    ViewBag.Locations = _locationService.GetAllLocation();
=======
            //ViewBag.Locations = _locationService.GetAllLocation();
            return View(headquarter);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Headquarters? headquarter = _headquartersService.GetAllHeadquarters().FirstOrDefault(r => r.HeadquartersId == id);
            if (headquarter == null)
            {
                return NotFound();
            }

            //ViewBag.Locations = _locationService.GetAllLocation();
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //    return View(headquarter);
        //}

<<<<<<< HEAD
        //[HttpPost]
        //public IActionResult UpdateHeadquarters(Headquarters headquarter)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _headquartersService.UpdateHeadquarters(headquarter);
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.Locations = _locationService.GetAllLocation();
=======
        [HttpPost]
        public IActionResult Edit(Headquarters headquarter)
        {
            if (ModelState.IsValid)
            {
                _headquartersService.UpdateHeadquarters(headquarter);
                return RedirectToAction("Index");
            }

            //ViewBag.Locations = _locationService.GetAllLocation();
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //    return View(headquarter);
        //}

        //[HttpGet]
        //public IActionResult DeleteHeadquarter(int id)
        //{
        //    Headquarters? headquarter = _headquartersService.GetHeadquarterById(id);
        //    if (headquarter == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(headquarter);
        //}

        //[HttpPost]
        //public IActionResult DeleteHeadquarterConfirmed(int id)
        //{
        //    Headquarters? headquarter = _headquartersService.GetHeadquarterById(id);
        //    if (headquarter == null)
        //    {
        //        return NotFound();
        //    }

        //    _headquartersService.DeleteHeadquarter(id);

        //    return RedirectToAction("Index");
        //}
    }
}
