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
    public class LogProduitFluent : EntityTypeConfiguration<LogProduit>
    {
        public LogProduitFluent()
        {
            ToTable("APP_LogProduit");
            HasKey(lp => lp.Id);
            Property(lp => lp.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(lp => lp.Message).HasColumnName("Message").IsRequired().HasMaxLength(500);
            Property(lp => lp.Date).HasColumnName("Date").IsRequired();

            HasRequired(lp => lp.Produit).WithMany().HasForeignKey(lp => lp.ProduitId);
        }
    }
}
