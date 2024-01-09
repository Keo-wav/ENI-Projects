using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Module7DemoEntity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppContext dbContext = new AppContext();

            dbContext.Personnes.Add(new Personne { Nom = "Moi", Age = 34 });
            dbContext.Personnes.Add(new Personne { Nom = "Bat", Age = 35 });

            dbContext.SaveChanges();

            Console.WriteLine("Personnes :");
            foreach (var personne in dbContext.Personnes)
            {
                Console.WriteLine($"- {personne.Nom}");
            }
            Console.WriteLine("");
            Console.WriteLine("Consultation d'une personne par des critères de recherche :");
            var firstUser = dbContext.Personnes.Where(p => p.Nom == "Moi");

            //firstUser.Nom = "Keo";
            //dbContext.SaveChanges();

            // remove a single entry from a table
            if (firstUser == null) {
                Console.WriteLine("No such entry in the Persons database");
            }
            else {
                dbContext.Personnes.Remove((Personne)firstUser);
            }
            dbContext.SaveChanges();

            // remove all entries from a table
            dbContext.Personnes.RemoveRange(dbContext.Personnes);
            dbContext.SaveChanges();
        }
    }
}
