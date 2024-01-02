using QuelMedecin.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuelMedecinApp
{
	class TestAdresse
	{
		static void Main(string[] args)
		{
			Console.WriteLine("__________________________ Adresses ______________________________");
			Adresse sh = new Adresse("ZAC du Moulin Neuf", 2, "B", "rue Benjamin Franklin", 44800, "Saint Herblain");
			Adresse nio = new Adresse(19, null, "avenue Léo Lagrange", 79000, "Niort");
			Adresse comp = new Adresse(4, null, "Rue des Glatiniers", 2100, "Saint-Quentin");

			sh.ToString();
			Console.WriteLine("------------------------------------------------------------------");
			nio.ToString();
			Console.WriteLine("------------------------------------------------------------------");
			comp.ToString();
		}
    }
}
