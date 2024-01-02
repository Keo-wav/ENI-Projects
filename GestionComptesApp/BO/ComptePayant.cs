using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionComptes.BO
{
    public class ComptePayant : Compte
    {

        private float commission;

        public float Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        public ComptePayant(string proprietaire, DateTime dateOuverture, float commission = 0) : base(proprietaire, dateOuverture)
        {
            this.commission = commission;
        }
        public override string Visualiser()
        {
            return base.Visualiser() + $"\nCommission : {Commission} euros";
        }
    }
}
