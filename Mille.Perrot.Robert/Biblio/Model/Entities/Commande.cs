using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model.Entities
{
    [DataContract]
    public class Commande
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime DateCommande { get; set; }

        [DataMember]
        public String Observation { get; set; }

        [DataMember]
        public int StatutId { get; set; }

        [DataMember]
        public Statut Statut { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public Client Client { get; set; }
    }
}
