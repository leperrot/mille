using Biblio.Model;
using Biblio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class CommandeQuery
    {
        private readonly Context _ctx;

        public CommandeQuery(Context ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Commande> GetAll()
        {
            return _ctx.Commandes;
        }

        public IQueryable<Commande> GetCommande(int id)
        {
            IQueryable<Commande> cli = _ctx.Commandes.Where(p => p.Id == id);
            if (cli.FirstOrDefault() == null)
            {
                throw new KeyNotFoundException();
            }
            return cli;
        }

        public IQueryable<Commande> GetLastCommandes()
        {
            IQueryable<Commande> coms;
            if (_ctx.Commandes.Count() >= 5)
                coms = _ctx.Commandes.OrderBy(c => c.DateCommande).Take(5);
            else coms = _ctx.Commandes.OrderBy(c => c.DateCommande).Take(_ctx.Commandes.Count());
            return coms;
        }
    }
}
