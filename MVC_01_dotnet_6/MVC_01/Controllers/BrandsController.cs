using Microsoft.AspNetCore.Mvc;
using MVC_01.Models;

namespace MVC_01.Controllers
{
    public class BrandsController : Controller
    {
        private readonly StoreDbContext _db;
        public BrandsController(StoreDbContext db) { _db = db; }
        public IActionResult Index()
        {
            return View(_db.Brands.ToList());
        }
    }
}
