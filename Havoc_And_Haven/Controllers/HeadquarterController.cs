﻿using Microsoft.AspNetCore.Mvc;

namespace Havoc_And_Haven.Controllers
{
    public class HeadquarterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
