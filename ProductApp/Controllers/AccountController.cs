using Microsoft.AspNetCore.Mvc;
using ProductApp.Database;
using ProductApp.Functionality;
using ProductApp.Service;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    public class AccountController : Controller
    {
        IAccountOperation accountOperation;
        public AccountController()
        {
            accountOperation = new AccountService();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAccount(Account acc) // viewModel
        {
            int temp = accountOperation.AccountCreate(acc);
            if(temp>0)
            {
                ViewBag.Message = "Account Created";
            }
            return View();
        }
        [HttpGet]
        public IActionResult LoginValidate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginValidate(Account acc) // viewModel
        {
            int temp = accountOperation.AccountValidate(acc.Username, acc.Password);
            if (temp > 0)
            {
                HttpContext.Session.SetString("Usr", acc.Username);
                return RedirectToAction("Index","Dashboard");
            }
            return View();
        }
    }
}
