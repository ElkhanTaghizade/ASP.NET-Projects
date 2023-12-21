﻿using Microsoft.AspNetCore.Mvc;
using WebApplication5.App;
using WebApplication5.Models;

namespace WebApplication5.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class CategoryController : Controller
    {
        public readonly AppDbContext appDbContext;
        public CategoryController(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }
        public IActionResult Index()
        {
            return View(appDbContext.Categories.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Categories categories)
        {
            appDbContext.Categories.Add(categories);
            appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
