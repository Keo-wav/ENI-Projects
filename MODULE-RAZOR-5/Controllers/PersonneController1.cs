using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Debugger.Contracts.HotReload;
using MODULE_RAZOR_5.Models;

namespace MODULE_RAZOR_5.Controllers
{
    public class PersonneController1 : Controller
    {
        // GET: PersonneController1
        public ActionResult Index()
        {
            var personnes = new List<Personne>
            {
                new Personne() { Name = "Quentin Dupieux", Age = 42, Id = 1},
                new Personne() { Name = "John Wish", Age = 12, Id = 2},
                new Personne() { Name = "John Gayboi", Age = 34, Id = 3}
            };
            return View(personnes);
        }

        // GET: PersonneController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonneController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonneController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PersonneController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonneController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: PersonneController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonneController1/Delete/5
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
