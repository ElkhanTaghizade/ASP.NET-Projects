using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication5.App;
using WebApplication5.Models;

namespace WebApplication5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public readonly AppDbContext appDbContext;
        public HomeController(AppDbContext _appDbContext) 
        {
            this.appDbContext = _appDbContext;
        }
        public  IActionResult IndexA()
        {
            return View();
        }
    }
}
