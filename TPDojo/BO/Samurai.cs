﻿using System;
using System.Collections.Generic;
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
        public Weapon? Weapon { get; set; }
    }
}
