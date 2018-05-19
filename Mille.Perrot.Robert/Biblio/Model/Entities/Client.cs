using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.Model.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public String Nom { get; set; }

        public String Prenom { get; set; }

        public Boolean Actif { get; set; }
    }
}
