using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model.Entities
{
    [DataContract]
    public class Produit
    {
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public long Code { get; set; }

        [Required]
        [DataMember]
        public String Libelle { get; set; }

        [DataMember]
        public String Desc { get; set; }

        [DataMember]
        public Boolean Actif { get; set; }

        [Required]
        [DataMember]
        public int Stock { get; set; }

        [Required]
        [DataMember]
        public double Prix { get; set; }

        [DataMember]
        public int CategorieId { get; set; }

        [DataMember]
        public Categorie Categorie { get; set; }
    }
}
