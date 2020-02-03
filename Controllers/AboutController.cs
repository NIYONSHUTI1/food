using Microsoft.AspNetCore.Mvc;

namespace food.Controllers
{
    public class AboutController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}