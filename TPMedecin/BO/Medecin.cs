namespace QuelMedecinApp.BO
{
    public class Medecin
    {
        private string prenom;

        public Medecin(string nom, string prenom, string numeroTelephone)
        {
            Nom = nom.ToUpper();
            this.prenom = prenom;
            NumeroTelephone = numeroTelephone;
        }

        public static int Tarif { get; set; } = 25;
        public string NumeroTelephone { get; set; }
        public string Nom { get; }
        public string Prenom
        {
            get { return char.ToUpper(prenom[0]) + prenom.Substring(1).ToLower(); }
            set { prenom = value; }
        }

        public void Afficher()
        {
            Console.WriteLine($"{Nom} {Prenom}");
            Console.WriteLine($"Téléphone : {NumeroTelephone}");
            Console.WriteLine($"Tarif : {Tarif}");
        }
    }
}
