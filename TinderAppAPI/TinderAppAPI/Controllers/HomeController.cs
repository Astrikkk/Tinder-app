using Microsoft.AspNetCore.Mvc;

namespace TinderAppAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
