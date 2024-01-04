using EscapeGame.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EscapeGame.Controllers {
    public class MachinController : Controller {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger) {
        //    _logger = logger;
        //}

        //public IActionResult Index() {
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error() {
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        public IActionResult Truc()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Machin/Bidule/{id}")]
        public IActionResult Bidule([FromRoute] int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult Jo()
        {
            return View();
        }
    }
}