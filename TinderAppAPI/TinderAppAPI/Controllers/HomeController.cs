using Microsoft.AspNetCore.Mvc;

namespace TinderAppAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        #region products
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult PremiumFeatures()
        {
            return View();
        }
        public IActionResult SubscriptionTiers()
        {
            return View();
        }
        public IActionResult TinderPlus()
        {
            return View();
        }
        public IActionResult TinderGold()
        {
            return View();
        }
        public IActionResult TinderPlatinum()
        {
            return View();
        }
        public IActionResult TinderSelect()
        {
            return View();
        }
        #endregion
        public IActionResult Learn()
        {
            return View();
        }
        #region Safety
        public IActionResult Safety()
        {
            return View();
        }
        public IActionResult CommunityGuadlines()
        {
            return View();
        }
        public IActionResult SafetyTips()
        {
            return View();
        }
        public IActionResult SafetyAndPolicy()
        {
            return View();
        }
        public IActionResult SafetyAndReporting()
        {
            return View();
        }
        public IActionResult Security()
        {
            return View();
        }
        #endregion
        public IActionResult Support()
        {
            return View();
        }
        public IActionResult Download()
        {
            return View();
        }
    }
}
