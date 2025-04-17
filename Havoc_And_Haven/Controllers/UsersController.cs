using Havoc_And_Haven.BLL;
using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Havoc_And_Haven.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;
        private readonly HeadquartersService _hqService;
        private readonly LairService _lairService;

        public UserController(UserService userService, HeadquartersService hqService, LairService lairService)
        {
            _userService = userService;
            _hqService = hqService;
            _lairService = lairService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Users> users = _userService.GetAllUsers();
            return View(users);
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            List<Headquarters> headquarters = _hqService.GetAllHeadquarters();
            List<Lair> lairs = _lairService.GetAllLairs();

            ViewBag.Headquarters = headquarters;
            ViewBag.Lairs = lairs;

            return View(new Users());
        }

        [HttpPost]
        public IActionResult AddUser(Users user)
        {
            if (ModelState.IsValid)
            {
                _userService.AddUser(user);
                return RedirectToAction("Index");
            }

            List<Headquarters> headquarters = _hqService.GetAllHeadquarters();
            List<Lair> lairs = _lairService.GetAllLairs();

            ViewBag.Headquarters = headquarters;
            ViewBag.Lairs = lairs;

            return View(user);
        }

        [HttpGet]
        public IActionResult EditUser(int id)
        {
            Users user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            List<Headquarters> headquarters = _hqService.GetAllHeadquarters();
            List<Lair> lairs = _lairService.GetAllLairs();

            ViewBag.Headquarters = headquarters;
            ViewBag.Lairs = lairs;

            return View(user);
        }

        [HttpPost]
        public IActionResult EditUser(Users user)
        {
            if (ModelState.IsValid)
            {
                _userService.UpdateUser(user);
                return RedirectToAction("Index");
            }

            List<Headquarters> headquarters = _hqService.GetAllHeadquarters();
            List<Lair> lairs = _lairService.GetAllLairs();

            ViewBag.Headquarters = headquarters;
            ViewBag.Lairs = lairs;

            return View(user);
        }

        [HttpGet]
        public IActionResult ViewProfile(int id)
        {
            Users user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpGet]
        public IActionResult DeleteUser(int id)
        {
            Users user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        public IActionResult DeleteUserConfirmed(int id)
        {
            _userService.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}
