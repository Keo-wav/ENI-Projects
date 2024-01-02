
namespace BO
{
    public class Medecin
    {
        // instance attributes
        private string nom; // has to be capitalized
        private string prenom; // first letter has to be capitalized
        private string numeroDeTelephone;

        // class attribute
        private static int tarif = 25;

        // constructor
        public Medecin(string nom, string prenom, string numeroDeTelephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.numeroDeTelephone = numeroDeTelephone;
        }

        // public properties
        public string Nom
        { get { return nom.ToUpper(); } }

        public string Prenom
        { get { return prenom.ToUpper(); } }

        public string NumeroDeTelephone
        {
            get { return numeroDeTelephone; }
            set { numeroDeTelephone = value; }
        }

        public static int Tarif
        {
            get { return tarif; }
            set { Medecin.tarif = value; }
        }

        // instance method
        public void Afficher()
        {
            Console.WriteLine($"{this.nom} {this.prenom}");
            Console.WriteLine($"Téléphone : {this.numeroDeTelephone}");
            Console.WriteLine($"Tarif : {Medecin.tarif}€");
        }
    }
}
