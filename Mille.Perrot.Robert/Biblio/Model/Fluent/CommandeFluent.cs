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
    public class CommandeFluent : EntityTypeConfiguration<Commande>
    {
        public CommandeFluent()
        {
            ToTable("APP_Commande");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Observation).HasColumnName("Observation").HasMaxLength(500);
            Property(c => c.DateCommande).HasColumnName("DateCommande").IsRequired();

            HasRequired(c => c.Client).WithMany().HasForeignKey(c => c.ClientId);
            HasRequired(c => c.Statut).WithMany().HasForeignKey(c => c.StatutId);
        }
    }
}
