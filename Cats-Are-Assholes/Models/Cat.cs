namespace TPChats.Models {
    public class Cat {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Couleur { get; set; }

        public static List<Cat> GetMeuteDeChats() {
            var i = 1;
            return new List<Cat> {
                new Cat{Id=i++,Nom = "Felix",Age = 3,Couleur = "Roux"},
                new Cat{Id=i++,Nom = "Minette",Age = 1,Couleur = "Noire"},
                new Cat{Id=i++,Nom = "Miss",Age = 10,Couleur = "Blanche"},
                new Cat{Id=i++,Nom = "Garfield",Age = 6,Couleur = "Gris"},
                new Cat{Id=i++,Nom = "Chatran",Age = 4,Couleur = "Fauve"},
                new Cat{Id=i++,Nom = "Minou",Age = 2,Couleur = "Blanc"},
                new Cat{Id=i,Nom = "Bichette",Age = 12,Couleur = "Rousse"}
            };
        }
    }
}
