using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF.DataContracts
{
    [DataContract]
    public class ProduitContract
    {
        public ProduitContract(int id, long code, String libelle, String desc, Boolean actif, int stock, double prix, int categorieId, CategorieContract categorie)
        {
            Id = id;
            Code = code;
            Libelle = libelle;
            Desc = desc;
            Actif = actif;
            Stock = stock;
            Prix = prix;
            CategorieId = categorieId;
            Categorie = categorie;
        }

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
        public CategorieContract Categorie { get; set; }
    }
}