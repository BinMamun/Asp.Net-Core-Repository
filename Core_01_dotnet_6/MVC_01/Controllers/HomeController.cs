﻿using Microsoft.AspNetCore.Mvc;

namespace MVC_01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
