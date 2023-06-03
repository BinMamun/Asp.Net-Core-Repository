using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Core_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_01.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeDbContext db;
        public EmployeesController(EmployeeDbContext db) { this.db = db; }

        public IActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee e)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(e);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(e);
        }

        public IActionResult Edit(int id)
        {
            return View(db.Employees.First(x => x.EmployeeId == id));
        }
        [HttpPost]
        public IActionResult Edit(Employee e)
        {
            if (ModelState.IsValid)
            {
                db.Entry(e).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(e);
        }

        public IActionResult Delete(int id)
        {
            return View(db.Employees.First(x => x.EmployeeId == id));
        }
        [HttpPost]
        public IActionResult Delete(Employee e)
        {
            db.Entry(e).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
