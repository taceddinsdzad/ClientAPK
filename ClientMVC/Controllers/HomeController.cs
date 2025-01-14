using Microsoft.AspNetCore.Mvc;

namespace ClientMVC.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
