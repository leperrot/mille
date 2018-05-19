using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model.Entities
{
    public class LogProduit
    {
        public int Id { get; set; }

        public String Message { get; set; }

        public DateTime Date { get; set; }

        public int ProduitId { get; set; }

        public Produit Produit { get; set; }
    }
}
