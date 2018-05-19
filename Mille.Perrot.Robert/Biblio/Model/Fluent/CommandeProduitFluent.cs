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
    public class CommandeProduitFluent : EntityTypeConfiguration<CommandeProduit>
    {
        public CommandeProduitFluent()
        {
            ToTable("APP_CommandeProduit");
            HasKey(cp => new { cp.CommmandeId, cp.ProduitId });
            Property(cp => cp.Quantite).HasColumnName("Quantite").IsRequired();

            HasRequired(cp => cp.Commande).WithMany().HasForeignKey(cp => cp.CommmandeId);
            HasRequired(cp => cp.Produit).WithMany().HasForeignKey(cp => cp.ProduitId);
        }
    }
}
