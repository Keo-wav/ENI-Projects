using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComptes.BO
{
    public class CompteEpargne : Compte
    {
        private double tauxInteret = 0.06;

        public CompteEpargne(string proprietaire, DateTime dateOuverture, double solde = 0) : base(proprietaire, dateOuverture)
        {
            this.Solde = solde;
        }

        public double CalculerInteret()
        {
            return base.Solde *= tauxInteret;
        }

        public override string Visualiser()
        {
            return base.Visualiser() + $"\nTaux d'intérêt : {tauxInteret * 100}%";
        }
    }
}
