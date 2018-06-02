using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF.DataContracts
{
    [DataContract]
    public class CategorieContract
    {
        public CategorieContract(int id, String libelle, Boolean actif)
        {
            Id = id;
            Libelle = libelle;
            Actif = actif;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Libelle { get; set; }

        [DataMember]
        public Boolean Actif { get; set; }
    }
}