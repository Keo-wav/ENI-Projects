using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using TPPreferences.Models;

namespace TPPreferences.Controllers
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
            var cookieCounter = Request.Cookies["Counter"] ?? "0";
            var counter = int.Parse(cookieCounter);
            counter++;
            ViewData["Counter"] = counter;

            Response.Cookies.Append("Counter", counter.ToString());
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //HttpContext.Session.SetString("CookieBoi", "valeur de l'attribut de session");
        //ViewBag.Message = HttpContext.session.GetString("CookieBoi");
    }
}
