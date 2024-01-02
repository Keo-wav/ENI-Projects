using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Patient
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NumeroDeTelephone { get; set; }
        public char Sexe { get; set; }
        public long NumSecu { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Commentaires { get; set; }

        public Patient(string nom, string prenom, string numeroDeTelephone,
            char sexe, long numSecu, DateTime dateDeNaissance, string commentaires = "")
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.NumeroDeTelephone = numeroDeTelephone;
            this.Sexe = sexe;
            this.NumSecu = numSecu;
            this.DateDeNaissance = dateDeNaissance;
            this.Commentaires = commentaires;
        }

        public void Afficher()
        {
            string sexe = this.Sexe == 'F' ? "Féminin" : "Masculin";
            // formater date de naissance
            Console.WriteLine($"{Nom} {Prenom}");
            Console.WriteLine($"{NumeroDeTelephone}");
            Console.WriteLine($"{sexe}");
            Console.WriteLine($"{NumSecu}");
            Console.WriteLine($"{DateDeNaissance}");
            Console.WriteLine($"{Commentaires}");
        }
    }
}
