using Microsoft.AspNetCore.Mvc;
using mustyGames.Models;
using System.Diagnostics;
using System.Net.Mail;

namespace mustyGames.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
			var value = HttpContext.Session.GetString("UserSession");
			if (value == null)
			{
				return RedirectToAction("Index", "Login");
			}
			return View();
		}
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}