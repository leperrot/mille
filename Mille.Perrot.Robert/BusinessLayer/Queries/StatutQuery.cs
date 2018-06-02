using Biblio.Model;
using Biblio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class StatutQuery
    {
        private readonly Context _ctx;

        public StatutQuery(Context ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Statut> GetAll()
        {
            return _ctx.Statuts;
        }

        public IQueryable<Statut> GetStatut(int id)
        {
            return _ctx.Statuts.Where(c => c.Id == id);
        }
    }
}
