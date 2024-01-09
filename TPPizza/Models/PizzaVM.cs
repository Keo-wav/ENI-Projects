using BO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TPPizza.Models
{
    public class PizzaVM
    {
        public string Nom { get; set; }
        public SelectList Pate { get; set; }
        public SelectList Ingredients { get; set; }
    }
}
