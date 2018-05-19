using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Biblio.Model.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblio.Model.Fluent
{
    public class ProduitFluent : EntityTypeConfiguration<Produit>
    {
        public ProduitFluent()
        {
            ToTable("APP_Produit");
            HasKey(p => p.Id);
            Property(p => p.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Libelle).HasColumnName("Description");
            Property(p => p.Prix).HasColumnName("Prix").IsRequired();
            Property(p => p.Code).HasColumnName("Code").IsRequired();
            Property(p => p.Desc).HasColumnName("Desc").HasMaxLength(500);
            Property(p => p.Actif).HasColumnName("Actif");
            Property(p => p.Stock).HasColumnName("Stock").IsRequired();

            HasRequired(p => p.Categorie).WithMany().HasForeignKey(p => p.CategorieId);
        }
    }
}
