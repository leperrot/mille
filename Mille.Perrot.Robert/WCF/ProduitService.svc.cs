using Biblio.Model.Entities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCF.DataContracts;

namespace WCF
{
    public class ProduitService : IProduitService
    {
        public List<Produit> GetProduits()
        {
            Manager manager = Manager.Instance;
            return manager.GetAllProduit();
        }

        public int GetStock(int id)
        {
            Manager manager = Manager.Instance;
            Produit p;
            try
            {
                p = manager.GetProduit(id);
            }catch(Exception e)
            {
                throw e;
            }
            return p.Stock;
        }
    }
}
