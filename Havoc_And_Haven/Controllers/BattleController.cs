using Havoc_And_Haven.BL;
using Havoc_And_Haven.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Havoc_And_Haven.Controllers {
    public class BattleController : Controller {
        private readonly BattleService _battleService;

        public BattleController(BattleService battleService) {
            _battleService = battleService;
        }

        public IActionResult Index() {
            List<Battle> battles = _battleService.GetAllBattles();
            ViewBag.Heros = _battleService.GetHeroes();
            ViewBag.Villians = _battleService.GetVillains();
            return View(battles);
        }

        [HttpGet]
        public IActionResult Create() {
            ViewBag.Crises = _battleService.GetAllCrises();
            ViewBag.Heros = _battleService.GetHeroes();
            ViewBag.Villians = _battleService.GetVillains();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Battle battle) {
            if (ModelState.IsValid) {
                _battleService.CreateBattle(battle);
                return RedirectToAction("Index");
            } else {
                foreach (var value in ModelState.Values) {
                    foreach (var error in value.Errors) {
                        Console.WriteLine(error.ErrorMessage); 
                    }
                }
            }

            ViewBag.Crises = _battleService.GetAllCrises();
            ViewBag.Heros = _battleService.GetHeroes();
            ViewBag.Villians = _battleService.GetVillains();
            return View(battle);
        }

        [HttpPost]
        public IActionResult Delete(int id) {
            Battle battle = _battleService.GetBattleById(id);
            if (battle != null) {
                _battleService.DeleteBattle(id);
                return RedirectToAction("Index");
            }
            return Content("Not found!");
        }

    }
}
