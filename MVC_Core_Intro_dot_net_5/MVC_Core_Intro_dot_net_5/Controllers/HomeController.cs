using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_Intro_dot_net_5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
