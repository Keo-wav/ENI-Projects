using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7DemoEntity
{
    public class AppContext : DbContext
    {
        public DbSet<Personne> Personnes {  get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;" + 
                "Database=Module7DemoEntity;" + 
                "MultipleActiveResultSets=true");
        }


    }
}
