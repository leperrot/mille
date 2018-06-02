using System;
using System.Collections.Generic;
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

        [DataMember]
        public long Code { get; set; }

        [DataMember]
        public String Libelle { get; set; }

        [DataMember]
        public String Desc { get; set; }

        [DataMember]
        public Boolean Actif { get; set; }

        [DataMember]
        public int Stock { get; set; }

        [DataMember]
        public double Prix { get; set; }

        [DataMember]
        public int CategorieId { get; set; }

        [DataMember]
        public Categorie Categorie { get; set; }
    }
}
