using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoEntityCRUD.Models;

    public class AppContext : DbContext
    {
        public AppContext (DbContextOptions<AppContext> options)
            : base(options)
        {
        }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder
            .UseSqlServer("Server=(localdb)\\mssqllocaldb;" +
            "Database=DemoEntityCRUDdb;" +
            "MultipleActiveResultSets=true");
    }

    public DbSet<DemoEntityCRUD.Models.Student> Student { get; set; } = default!;
    }
