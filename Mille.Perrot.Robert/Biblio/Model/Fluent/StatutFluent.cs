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
    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("APP_Statut");
            HasKey(s => s.Id);
            Property(s => s.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Libelle).HasColumnName("Libelle").HasMaxLength(150);
        }
    }
}
