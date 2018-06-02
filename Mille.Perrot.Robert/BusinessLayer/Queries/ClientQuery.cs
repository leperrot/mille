using Biblio.Model;
using Biblio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class ClientQuery
    {
        private readonly Context _ctx;

        public ClientQuery(Context ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Client> GetAll()
        {
            return _ctx.Clients;
        }

        public IQueryable<Client> GetClient(int id)
        {
            IQueryable<Client> cli = _ctx.Clients.Where(p => p.Id == id);
            if (cli.FirstOrDefault() == null)
            {
                throw new KeyNotFoundException();
            }
            return cli;
        }
    }
}
