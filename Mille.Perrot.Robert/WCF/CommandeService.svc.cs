using Biblio.Model.Entities;
using BusinessLayer;
using System;
using System.Collections.Generic;

namespace WCF
{
    public class CommandeService : ICommandeService
    {
        public List<Commande> GetCommandes()
        {
            Manager manager = Manager.Instance;
            return manager.GetAllCommande();
        }
    }
}
