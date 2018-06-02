using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model.Entities
{
    [DataContract]
    public class CommandeProduit
    {
        [DataMember]
        public int ProduitId { get; set; }

        [DataMember]
        public Produit Produit { get; set; }

        [DataMember]
        public int CommmandeId { get; set; }

        [DataMember]
        public Commande Commande { get; set; }

        [DataMember]
        public int Quantite { get; set; }
    }
}
