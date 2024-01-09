﻿using BO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using TPPizza.Models;

namespace TPPizza.Controllers {
    public class PizzaController : Controller {
        private static List<Pizza> pizzas = new List<Pizza> {
            new Pizza{Id = 1, Nom = "Calzone", Pate = Pizza.PatesDisponibles[1], Ingredients = new List<Ingredient>{ Pizza.IngredientsDisponibles[0], Pizza.IngredientsDisponibles[1]} },
            new Pizza{Id = 2, Nom = "Reine", Pate = Pizza.PatesDisponibles[0], Ingredients = new List<Ingredient>{ Pizza.IngredientsDisponibles[1], Pizza.IngredientsDisponibles[3], Pizza.IngredientsDisponibles[4]} },
        };

        // GET: PizzaController
        public ActionResult Index() {
            return View(pizzas);
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id) {
            Pizza? pizza = pizzas.Find(p => p.Id == id);
            if(pizza == null) {
                return NotFound();
            }
            return View(pizza);
        }

        // GET: PizzaController/Create
        public ActionResult Create() {
            return View(new PizzaVM());
        }

        // POST: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PizzaVM pizzaVM) {
            if (pizzaVM.IdsIngredients.Count <= 2 && pizzaVM.IdsIngredients.Count >= 5)
            {
                ModelState.AddModelError("IdsIngredients", "Votre pizza doit inclure entre 2 et 5 ingrédients.");
                return View(pizzaVM);
            }
            else
            {
                try {
                    pizzas.Add(new Pizza {
                        Id = pizzas.Any()?pizzas.Max(p => p.Id)+1:1,
                        Nom = pizzaVM.Nom,
                        Pate = Pizza.PatesDisponibles.First(p => p.Id == pizzaVM.IdPate),
                        Ingredients = Pizza.IngredientsDisponibles.Where(i => pizzaVM.IdsIngredients.Contains(i.Id)).ToList()
                    });
                    return RedirectToAction(nameof(Index));
                } catch {
                    return View();
                }
            }
        }

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id) {
            Pizza? pizza = pizzas.Find(p => p.Id == id);
            if(pizza == null) {
                return NotFound();
            }
            return View(new PizzaVM {
                Id = pizza.Id,
                Nom = pizza.Nom,
                IdPate = pizza.Pate.Id,
                IdsIngredients = pizza.Ingredients.Select(i => i.Id).ToList()
            });
        }

        // POST: PizzaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PizzaVM pizzaVM) {
            try {
                Pizza? pizza = pizzas.Find(p => p.Id == pizzaVM.Id);
                if(pizza == null) {
                    return NotFound();
                }
                pizza.Nom = pizzaVM.Nom;
                pizza.Pate = Pizza.PatesDisponibles.First(p => p.Id == pizzaVM.IdPate);
                pizza.Ingredients = Pizza.IngredientsDisponibles.Where(i => pizzaVM.IdsIngredients.Contains(i.Id)).ToList();
                return RedirectToAction(nameof(Index));
            } catch {
                return View(pizzaVM);
            }
        }

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id) {
            Pizza? pizza = pizzas.Find(p => p.Id == id);
            if(pizza == null) {
                return NotFound();
            }
            return View(pizza);
        }

        // POST: PizzaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                Pizza? pizza = pizzas.Find(p => p.Id == id);
                if(pizza == null) {
                    return NotFound();
                }
                pizzas.Remove(pizza);
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
