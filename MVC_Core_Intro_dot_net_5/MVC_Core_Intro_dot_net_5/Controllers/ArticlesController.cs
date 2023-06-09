﻿using Microsoft.AspNetCore.Mvc;
using MVC_Core_Intro_dot_net_5.Models;
using System.Linq;

namespace MVC_Core_Intro_dot_net_5.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ArticleDbContext _db;
        public ArticlesController(ArticleDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Articles.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Article a)
        {
            if (ModelState.IsValid)
            {
                _db.Articles.Add(a);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(a);
        }
    }
}
