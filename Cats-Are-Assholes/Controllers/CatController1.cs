using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cats_Are_Assholes.Controllers
{
    public class CatController1 : Controller
    {
        // GET: CatController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: CatController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CatController1/Create (DELETED)
        // POST: CatController1/Create (DELETED)
        // GET: CatController1/Edit/5 (DELETED)
        // POST: CatController1/Edit/5 (DELETED)

        // GET: CatController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
