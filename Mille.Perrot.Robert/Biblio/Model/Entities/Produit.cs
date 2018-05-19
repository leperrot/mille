using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model.Entities
{
    public class Produit
    {
        public int Id { get; set; }

        public long Code { get; set; }

        public String Libelle { get; set; }

        public String Desc { get; set; }

        public Boolean Actif { get; set; }

        public int Stock { get; set; }

        public double Prix { get; set; }

        public int CategorieId { get; set; }

        public Categorie Categorie { get; set; }
    }
}
