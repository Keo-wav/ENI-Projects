using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public override Weapon? Weapon { get; set; }
    }
}
