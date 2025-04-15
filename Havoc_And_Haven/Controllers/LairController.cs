using Havoc_And_Haven.BLL;
using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;

namespace Havoc_And_Haven.Controllers
{
<<<<<<< HEAD
    public class LairController : Controller {
        //    private readonly LairService _lairService;
        //    private readonly LocationService _locationService;

        //    public LairController(LairService lairService, LocationService locationService)
        //    {
        //        _lairService = lairService;
        //        _locationService = locationService;
        //    }
=======
    public class LairController : Controller
    {
        private readonly LairService _lairService;
        //private readonly LocationService _locationService;

        public LairController(LairService lairService)
        {
            _lairService = lairService;
            //_locationService = locationService;
        }
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //    public IActionResult Index()
        //    {
        //        List<Lair> lairs = _lairService.GetAllLairs();
        //        return View(lairs);
        //    }

<<<<<<< HEAD
        //    [HttpGet]
        //    public IActionResult AddLair()
        //    {
        //        ViewBag.Locations = _locationService.GetAllLocation();
=======
        [HttpGet]
        public IActionResult Create()
        {
            //ViewBag.Locations = _locationService.GetAllLocation();
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //        return View(new Lair());
        //    }

<<<<<<< HEAD
        //    [HttpPost]
        //    public IActionResult AddLair(Lair lair)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            lair.Location = _locationService.GetLocationById(lair.LocationId);
=======
        [HttpPost]
        public IActionResult Create(Lair lair)
        {
            if (ModelState.IsValid)
            {
                //lair.Location = _locationService.GetLocationById(lair.LocationId);
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //            _lairService.AddLair(lair);

        //            return RedirectToAction("Index");
        //        }

<<<<<<< HEAD
        //        ViewBag.Locations = _locationService.GetAllLocation();
        //        return View(lair);
        //    }

        //    [HttpGet]
        //    public IActionResult UpdateHeadquarters(int id)
        //    {
        //        Lair? lair = _lairService.GetAllLairs().FirstOrDefault(r => r.LairId == id);
        //        if (lair == null)
        //        {
        //            return NotFound();
        //        }

        //        ViewBag.Locations = _locationService.GetAllLocation();
=======
            //ViewBag.Locations = _locationService.GetAllLocation();
            return View(lair);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Lair? lair = _lairService.GetAllLairs().FirstOrDefault(r => r.LairId == id);
            if (lair == null)
            {
                return NotFound();
            }

            //ViewBag.Locations = _locationService.GetAllLocation();
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //        return View(lair);
        //    }

<<<<<<< HEAD
        //    [HttpPost]
        //    public IActionResult UpdateHeadquarters(Lair lair)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _lairService.UpdateLair(lair);
        //            return RedirectToAction("Index");
        //        }

        //        ViewBag.Locations = _locationService.GetAllLocation();
=======
        [HttpPost]
        public IActionResult Edit(Lair lair)
        {
            if (ModelState.IsValid)
            {
                _lairService.UpdateLair(lair);
                return RedirectToAction("Index");
            }

            //ViewBag.Locations = _locationService.GetAllLocation();
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //        return View(lair);
        //    }

<<<<<<< HEAD
        //    [HttpGet]
        //    public IActionResult DeleteHeadquarter(int id)
        //    {
        //        Lair? lair = _lairService.GetLairById(id);
        //        if (lair == null)
        //        {
        //            return NotFound();
        //        }
=======
        [HttpGet]
        public IActionResult DeleteLair(int id)
        {
            Lair? lair = _lairService.GetLairById(id);
            if (lair == null)
            {
                return NotFound();
            }
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //        return View(lair);
        //    }

<<<<<<< HEAD
        //    [HttpPost]
        //    public IActionResult DeleteHeadquarterConfirmed(int id)
        //    {
        //        Lair? lair = _lairService.GetLairById(id);
        //        if (lair == null)
        //        {
        //            return NotFound();
        //        }
=======
        [HttpPost]
        public IActionResult DeleteLairConfirmed(int id)
        {
            Lair? lair = _lairService.GetLairById(id);
            if (lair == null)
            {
                return NotFound();
            }
>>>>>>> b4db471dc0cb9bcb12d70caffc177efb82bc572b

        //        _lairService.DeleteLair(id);

        //        return RedirectToAction("Index");
        //    }
    }
}
