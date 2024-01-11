using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        [DisplayFormat(NullDisplayText = "Aucune Arme")]
        public virtual Weapon? Weapon { get; set; }
        public int WeaponId { get; set; }
    }
}
