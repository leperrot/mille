using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model.Entities
{
    public class Categorie
    {
        public int Id { get; set; }

        public String Libelle { get; set; }

        public Boolean Actif { get; set; }
    }
}
