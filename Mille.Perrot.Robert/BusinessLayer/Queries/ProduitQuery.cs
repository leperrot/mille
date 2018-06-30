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

        public IQueryable<Produit> GetByLibelle(String lib)
        {
            IQueryable<Produit> prod = _ctx.Produits.Where(p => p.Libelle.Contains(lib));
            return prod;
        }

        public IQueryable<Produit> GetPref()
        {
            IQueryable<Produit> prods;
            if (_ctx.Produits.Count() >= 5)
                prods = _ctx.Produits.Take(5);
            else prods = _ctx.Produits.Take(_ctx.Produits.Count());
            return prods;
        }
    }
}
