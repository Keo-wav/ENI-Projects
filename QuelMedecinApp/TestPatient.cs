//Ajouter la référence au projet BO
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuelMedecinApp
{
    class TestPatient
    {
        static void Main(string[] args)
        {
			List<String> commentaires = new List<string>();
			commentaires.Add("Allergie aux arachides");
			Console.WriteLine("__________________________ Patient _______________________________");
			Patient hillary = new Patient("Vambuce", "Hillary", "0123456789", 'F', 287060244010154L,
					new DateTime(1987, 6, 2), commentaires);
			Patient ines = new Patient("Perret", "Inès", "0698745123", 'F', 245021067034521L, new DateTime(1945, 2, 10),
					null);
			Patient adhemar = new Patient("Pamamobe", "Adhémar", "0753428619", 'M', 192112192020142L,
					new DateTime(1992, 11, 21), null);

			hillary.Afficher();
			Console.WriteLine("------------------------------------------------------------------");
			ines.Afficher();
			Console.WriteLine("------------------------------------------------------------------");
			adhemar.Afficher();

			Console.WriteLine("Appuyez sur une touche pour sortir de l'application.");
			Console.ReadKey();
		}
    }
}
