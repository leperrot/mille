using Biblio.Model;
using Biblio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class ProduitQuery
    {
        private readonly Context _ctx;

        public ProduitQuery(Context ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Produit> GetAll()
        {
            return _ctx.Produits;
        }

        public IQueryable<Produit> GetByID(int id)
        {
            IQueryable<Produit> prod = _ctx.Produits.Where(p => p.Id == id);
            if(prod.FirstOrDefault() == null)
            {
                throw new KeyNotFoundException();
            }
            return prod;
        }
    }
}
