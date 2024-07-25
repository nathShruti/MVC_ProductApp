using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var userName = HttpContext.Session.GetString("Usr");
            ViewBag.USER = userName;
            return View();
        }
    }
}
