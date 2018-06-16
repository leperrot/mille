using Biblio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class ProdCommViewModels
    {
        public List<Produit> Prods { get; set; }
        public List<Commande> Comms { get; set; }
    }
}