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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;" + 
                "Database=Module7DemoEntity;" + 
                "MultipleActiveResultSets=true");
        }
    }
}
