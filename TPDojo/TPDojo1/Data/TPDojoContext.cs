using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BO;

    public class TPDojoContext : DbContext
    {
        public TPDojoContext (DbContextOptions<TPDojoContext> options)
            : base(options)
        {
        }

        public DbSet<BO.Weapon> Weapon { get; set; } = default!;

        public DbSet<BO.Samurai>? Samurai { get; set; }
    }
