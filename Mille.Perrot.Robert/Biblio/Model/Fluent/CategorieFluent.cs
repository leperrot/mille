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
    public class CategorieFluent : EntityTypeConfiguration<Categorie>
    {
        public CategorieFluent()
        {
            ToTable("APP_Categorie");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Libelle).HasColumnName("Libelle").HasMaxLength(150);
            Property(c => c.Actif).HasColumnName("Actif");
        }
    }
}
