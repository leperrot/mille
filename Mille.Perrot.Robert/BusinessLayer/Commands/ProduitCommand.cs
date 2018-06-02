using Biblio.Model;
using Biblio.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands
{
    class ProduitCommand
    {
        private readonly Context _ctx;

        public ProduitCommand(Context ctx)
        {
            _ctx = ctx;
        }

        public int Ajouter(Produit produit)
        {
            _ctx.Produits.Add(produit);
            return _ctx.SaveChanges();
        }

        public void Modifier(Produit prd)
        {
            Produit upPrd = _ctx.Produits.Where(p => p.Id == p.Id).FirstOrDefault();
            if (upPrd != null)
            {
                upPrd.Id = prd.Id;
                upPrd.Libelle = prd.Libelle;
                upPrd.Desc = prd.Desc;
                upPrd.Code = prd.Code;
                upPrd.Actif = prd.Actif;
                upPrd.Prix = prd.Prix;
                upPrd.Stock = prd.Stock;
                upPrd.CategorieId = prd.CategorieId;
                upPrd.Categorie = prd.Categorie;

            }
            _ctx.SaveChanges();
        }

        public void Supprimer(int produitID)
        {
            Produit delPrd = _ctx.Produits.Where(prd => prd.Id == produitID).FirstOrDefault();
            if (delPrd != null)
            {
                _ctx.Produits.Remove(delPrd);
            }
            _ctx.SaveChanges();
        }
    }
}
