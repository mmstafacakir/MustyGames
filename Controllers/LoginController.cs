using Microsoft.AspNetCore.Mvc;
using mustyGames.Models;

namespace mustyGames.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(String username, String password)
        {
            Authentication cslAuth=new Authentication();
            if(cslAuth.UsernamePasswordControl(username,password)) {
                HttpContext.Session.SetString("UserSession", "1");
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Message = cslAuth.ErrorMessage;
                return View();
            }
        }
    }
}