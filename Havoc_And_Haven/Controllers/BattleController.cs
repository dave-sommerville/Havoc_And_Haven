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
            return View(battles);
        }

        [HttpGet]
        public IActionResult Create() {
            ViewBag.Crises = _battleService.GetAllCrises();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Battle battle) {
            if (ModelState.IsValid) {
                _battleService.CreateBattle(battle);
                return RedirectToAction("Index");
            }

            ViewBag.Crises = _battleService.GetAllCrises();
            return View(battle);
        }
    }
}
