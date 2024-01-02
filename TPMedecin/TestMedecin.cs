using QuelMedecinApp.BO;

namespace QuelMedecinApp
{
    class TestMedecin
    {
        static void Main(string[] args)
        {
			Console.WriteLine("__________________________ Médecins ______________________________");
			Medecin melanie = new Medecin("Malalaniche", "Mélanie", "02.28.03.17.28");
			Medecin edmond = new Medecin("Bosapin", "Edmond", "+33 2 17 18 19 20");
			Medecin djemila = new Medecin("Table", "Djémila", "03-04-05-06-07");
			Medecin jp = new Medecin("Monlatin", "jean pierre", "07-66-33-06-07");

			melanie.Afficher();
			Console.WriteLine("------------------------------------------------------------------");
			edmond.Afficher();
			Console.WriteLine("------------------------------------------------------------------");
			djemila.Afficher();
			Console.WriteLine("------------------------------------------------------------------");
			jp.Afficher();

			Console.WriteLine("--------------- Changement du numéro de ce médecin ---------------");
			djemila.NumeroTelephone = "07-06-05-04-03";
			Console.WriteLine($"Nouveau numéro du Dr {djemila.Nom} : {djemila.NumeroTelephone}");

			Console.WriteLine("-- Changement du prix de la consultation pour tous les médecins --");
            Medecin.Tarif = 23;
			melanie.Afficher();
			Console.WriteLine("------------------------------------------------------------------");
			edmond.Afficher();
			Console.WriteLine("------------------------------------------------------------------");
			djemila.Afficher();
			Console.WriteLine("------------------------------------------------------------------");
			jp.Afficher();

			Console.WriteLine("Appuyez sur une touche pour sortir de l'application.");
			Console.ReadKey();
		}
    }
}
