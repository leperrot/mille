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
        public List<ProduitContract> GetProduits()
        {
            Manager manager = Manager.Instance;
            List<Produit> prods = manager.GetAllProduit();
            List<ProduitContract> prodsContracts = new List<ProduitContract>();
            prods.ForEach(p =>
            {
                Categorie cate = manager.GetCategorie(p.CategorieId);
                prodsContracts.Add(new ProduitContract(
                p.Id, p.Code, p.Libelle, p.Desc, p.Actif, p.Stock, p.Prix, p.CategorieId,
                new CategorieContract(
                    cate.Id, cate.Libelle, cate.Actif
                )));
            });
            return prodsContracts;
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
