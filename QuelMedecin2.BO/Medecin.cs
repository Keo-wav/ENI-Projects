using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuelMedecin.BO
{
    /// <summary>
    /// Décrit le concept de Medecin
    /// La classe doit être publique pour être visible du projet QuelMedecinApp
    /// </summary>
    public class Medecin
    {
        //les attributs privés
        private String nom;
        private String prenom;
        private String numeroDeTelephone;

        //l'attribut de classe
        //Le tarif est défini ici, car tous les Medecin partage le même tarif
        private static int tarif = 25;

        //les propriétés d'instances
        public String Nom
        {
            get { return nom; }
            //la propriété set est en accès limité à la classe
            private set
            {
                if (value != null && value != String.Empty)
                {
                    value = value.ToUpper(); //formater les données
                }
                nom = value; // valorisation de l'attribut nom;
            }
        }

        public String Prenom
        {
            get { return prenom; }
            set { 
                if (value != null && value != String.Empty)
                {
                    prenom = FormaterPrenom(value);
                }
            }
        }

        public String NumeroDeTelephone
        {
            get { return numeroDeTelephone; }
            set { numeroDeTelephone = value; }
        }


        //les propriétés de classe en syntaxe simplifiée
        public static int Tarif { get => tarif; set => tarif = value; }


        //le constructeur
        /// <summary>
        /// Constructeur : crée une instance de Medecin
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="numeroDeTelephone"></param>
        public Medecin(String nom, String prenom, String numeroDeTelephone)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.NumeroDeTelephone = numeroDeTelephone;
        }


        //une méthode de classe privée
        /// <summary>
        /// Formater le prénom
        /// </summary>
        /// <param name="prenom">le prénom à formater</param>
        /// <returns>le prénom formaté</returns>
        private static String FormaterPrenom(String prenom)
        {
            if (prenom != null && prenom != String.Empty)
            {
                String[] mots = prenom.Split(new char[] { ' ', '-' });
                prenom = String.Empty;
                foreach (String mot in mots)
                {
                    if (prenom.Length > 0) prenom += "-";
                    //la première lettre du mot passe en majuscule, les autres en minuscule.
                    prenom += mot[0].ToString().ToUpper() + mot.Substring(1, mot.Length - 1).ToLower();
                    
                }
            }
 
            return prenom;
        }

        //une méthode d'instance publique
        /// <summary>
        /// Affiche à la console l'état d'une instance de Medecin
        /// NOM Prénom
        /// Téléphone : XXXXXXXXXX
        /// Tarif : XX€
        /// </summary>
        public void Afficher()
        {
            Console.Write($"{this.Nom} {this.Prenom}\nTéléphone : {this.NumeroDeTelephone}\nTarif : {Medecin.Tarif}€\n");
        }

    }
}
