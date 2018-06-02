using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model.Entities
{
    [DataContract]
    public class Categorie
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Libelle { get; set; }

        [DataMember]
        public Boolean Actif { get; set; }
    }
}
