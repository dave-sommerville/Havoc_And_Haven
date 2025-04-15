using Microsoft.AspNetCore.Mvc;

namespace Havoc_And_Haven.Controllers {
    public class BattleController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
