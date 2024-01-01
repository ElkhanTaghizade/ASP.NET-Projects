using WebApplication5.Migrations;
using WebApplication5.Models;
using Slider = WebApplication5.Models.Slider;

namespace WebApplication5.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Slider { get; set; }
        public List<Products> Products { get; set; }



    }
}
