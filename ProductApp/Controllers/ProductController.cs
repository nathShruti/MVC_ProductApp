using System.Security;
using Microsoft.AspNetCore.Mvc;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Walk()
        {
            return View("w");
        }

        public ActionResult Address()
        {
            return View("a");
        }
    }
}
