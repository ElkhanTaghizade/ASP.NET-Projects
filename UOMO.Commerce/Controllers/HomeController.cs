using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using WebApplication5.App;
using WebApplication5.Models;
using WebApplication5.ViewModel;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly AppDbContext _appdbContext;
        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appdbContext = appDbContext;
        }

        public async Task <IActionResult> Index1()
        {
            List<Products> products = await _appdbContext.Products.Include(x=>x.Categories).ToListAsync();
            return View(products);
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Slider=_appdbContext.Slider.ToList(),
                Products=_appdbContext.Products.ToList()
            };
            return View(homeVM);
        }
        public IActionResult login_register()
        {
            List<Data> list = _appdbContext.Data.ToList();
            return View(list);
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult account_dashboard()
        {
            return View();
        }
        public IActionResult account_edit()
        {
            return View();
        }
        public IActionResult account_edit_adress()
        {
            return View();
        }
        public IActionResult account_orders()
        {
            return View();
        }
        public IActionResult account_wishlist()
        {
            return View();
        }
        public IActionResult blog_list2()
        {
            List<Products> product = _appdbContext.Products.Include(x => x.Categories).ToList();
            return View(product);
        }
        public IActionResult blog_single()
        {
            return View();
        }
        public IActionResult blog_details(int Id)
        {
          var product=_appdbContext.Products.FirstOrDefault(x=>x.Id == Id);
            return View(product);
        }
        public IActionResult coming_soon()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult faq()
        {
            return View();
        }
        public IActionResult product2_variable()
        {
            return View();
        }
        public IActionResult product6_outofstock()
        {
            return View();
        }
        public IActionResult reset_password()
        {
            return View();
        }
        public IActionResult shop_cart()
        {
            return View();
        }
        public IActionResult shop_checkout()
        {
            return View();
        }
        public IActionResult shop_order_complete()
        {
            return View();
        }
        public IActionResult shop12()
        {
            return View();
        }
        public IActionResult shop3()
        {
            return View();
        }
        public IActionResult error404()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}