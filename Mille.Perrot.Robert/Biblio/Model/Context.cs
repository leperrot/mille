using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Biblio.Model.Entities;
using Biblio.Model.Fluent;

namespace Biblio.Model
{
    public class Context : DbContext
    {
        public Context() : base("name=MilleDB")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.Add(new CategorieFluent());
            modelBuilder.Configurations.Add(new ClientFluent());
            modelBuilder.Configurations.Add(new CommandeFluent());
            modelBuilder.Configurations.Add(new CommandeProduitFluent());
            modelBuilder.Configurations.Add(new LogProduitFluent());
            modelBuilder.Configurations.Add(new ProduitFluent());
            modelBuilder.Configurations.Add(new StatutFluent());
        }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<CommandeProduit> CommandesProduits { get; set; }
        public DbSet<LogProduit> LogProduits { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Statut> Statuts { get; set; }
    }
}
