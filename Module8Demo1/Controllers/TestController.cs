using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Module8Demo1.Controllers
{
    public class TestController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        public TestController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            List<IdentityUser> users = userManager.Users.ToList();
            return View(users);
        }
    }
}
