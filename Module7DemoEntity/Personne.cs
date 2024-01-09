using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7DemoEntity
{
    public class Personne
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public int Age { get; set; }
        public int AdresseId { get; set; }
        public virtual Adresse Adresse { get; set; }
    }
}
