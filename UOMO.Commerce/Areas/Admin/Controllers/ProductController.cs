using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication5.App;
using WebApplication5.Extensions;
using WebApplication5.Models;

namespace WebApplication5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        public readonly AppDbContext appDbContext;
        public ProductController(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }
        public IActionResult Index()
        {
            var product=appDbContext.Products.Include(x=>x.Categories).ToList();
            return View(product);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = appDbContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Products product)
        {
            ViewBag.Category = appDbContext.Categories.ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }
            if (FileExtension.IsImage(product.File))
            {
                string imagename=await FileExtension.SaveAsync(product.File, "products");
                product.ImageUrl = imagename;
                appDbContext.Products.Add(product);
                appDbContext.SaveChanges();
            }
            else 
            {
                ModelState.AddModelError("Error","Wrong format");
                return View();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            ViewBag.Category = appDbContext.Categories.ToList();
            var oldproduct = appDbContext.Products.Find(Id);
            if (oldproduct != null)
            {
                return View(oldproduct);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Products product)
        {
            var oldproduct = appDbContext.Products.Find(product.Id);
            if (oldproduct != null)
            {
                oldproduct.Name = product.Name;
                appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var oldproduct = appDbContext.Products.Find(Id);
            if (oldproduct != null)
            {
                appDbContext.Products.Remove(oldproduct);
                appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
