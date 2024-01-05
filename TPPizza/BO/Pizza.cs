namespace BO {
    public class Pizza {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Pate Pate { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public static List<Ingredient> IngredientsDisponibles => new List<Ingredient> {
            new Ingredient{Id=1,Nom="Mozzarella"},
            new Ingredient{Id=2,Nom="Jambon"},
            new Ingredient{Id=3,Nom="Tomate"},
            new Ingredient{Id=4,Nom="Oignon"},
            new Ingredient{Id=5,Nom="Cheddar"},
            new Ingredient{Id=6,Nom="Saumon"},
            new Ingredient{Id=7,Nom="Champignon"},
            new Ingredient{Id=8,Nom="Poulet"}
        };

        public static List<Pate> PatesDisponibles => new List<Pate> {
            new Pate{ Id=1,Nom="Pâte fine, base crème"},
            new Pate{ Id=2,Nom="Pâte fine, base tomate"},
            new Pate{ Id=3,Nom="Pâte épaisse, base crême"},
            new Pate{ Id=4,Nom="Pâte épaisse, base tomate"}
        };

        //public static List<Pizza> pizzaList = new List<Pizza>
        //{
        //    new Pizza{ Id=1, Nom="Calzone", Pate = PatesDisponibles.First(x => x.Id == 2), Ingredients = (List<Ingredient>)IngredientsDisponibles.Where(i => i.Id == 1 && i.Id == 2)},
        //    new Pizza{ Id=2, Nom="Reine", Pate = PatesDisponibles.First(y => y.Id == 1), Ingredients = (List<Ingredient>)IngredientsDisponibles.Where(j => j.Id == 2 && j.Id == 4 && j.Id == 5)}
        //};
    }
}
