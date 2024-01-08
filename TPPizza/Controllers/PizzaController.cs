using BO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TPPizza.Controllers
{
    public class PizzaController : Controller
    {
        private static List<Pizza> pizzas = new List<Pizza> {
            new Pizza {
                Id=1, Nom="Calzone",
                Pate=Pizza.PatesDisponibles[1],
                Ingredients = new List<Ingredient>
                {
                    Pizza.IngredientsDisponibles[0],
                    Pizza.IngredientsDisponibles[1]
                }
            },
            new Pizza {
                Id=2, Nom="Reine",
                Pate=Pizza.PatesDisponibles[0],
                Ingredients = new List<Ingredient>
                {
                    Pizza.IngredientsDisponibles[1],
                    Pizza.IngredientsDisponibles[3],
                    Pizza.IngredientsDisponibles[4]
                }
            }
    };

        // GET: PizzaController
        public ActionResult Index()
        {
            return View(pizzas);
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id)
        {
            var pizzaDetails = pizzas.FirstOrDefault(p => p.Id == id);
            if (pizzaDetails == null)
                return NotFound();
            return View(pizzaDetails);
        }

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
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

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController/Edit/5
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

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            var pizzaDetails = pizzas.FirstOrDefault(p => p.Id == id);
            return View(pizzaDetails);
        }

        // POST: PizzaController/Delete/5
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
