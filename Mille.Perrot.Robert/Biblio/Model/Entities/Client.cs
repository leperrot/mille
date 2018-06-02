using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model.Entities
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Nom { get; set; }

        [DataMember]
        public String Prenom { get; set; }

        [DataMember]
        public Boolean Actif { get; set; }
    }
}
