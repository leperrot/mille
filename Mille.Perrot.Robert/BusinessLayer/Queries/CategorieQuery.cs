using Biblio.Model;
using Biblio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class CategorieQuery
    {
        private readonly Context _ctx;

        public CategorieQuery(Context ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Categorie> GetAll()
        {
            return _ctx.Categories;
        }

        public IQueryable<Categorie> GetCategorie(int id)
        {
            return _ctx.Categories.Where(c => c.Id == id);
        }
    }
}
