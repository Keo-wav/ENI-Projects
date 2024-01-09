using BO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TPPizza.Models {
    public class PizzaVM {
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 2, 
            ErrorMessage = "Le nom doit comporter entre {2} et {1} caractères.")]
        public string Nom { get; set; }
        [DisplayName("Pâte")]
        [Required(ErrorMessage = "Votre pizza doit au moins avoir une pâte.")]
        public int IdPate { get; set; }
        public SelectList ChoixPate => new SelectList(Pizza.PatesDisponibles, "Id", "Nom");
        [DisplayName("Ingrédients")]
        public List<int> IdsIngredients { get; set; }
        public SelectList ChoixIngredients => new SelectList(Pizza.IngredientsDisponibles, "Id", "Nom");
    }
}
