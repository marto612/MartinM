using Microsoft.AspNetCore.Mvc;

namespace Project3_MVCApp.Controllers
{
    public class ColorController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FavoriteColor = "Blue";
            return View();
        }
    }
}
