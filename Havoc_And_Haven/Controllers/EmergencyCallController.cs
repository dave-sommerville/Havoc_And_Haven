using Microsoft.AspNetCore.Mvc;

namespace Havoc_And_Haven.Controllers
{
    public class EmergencyCallController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
