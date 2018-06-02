using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblio.Model;
using Biblio.Model.Entities;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Context ctx = new Context();
                ctx.Categories.Add(new Categorie { Actif = true, Libelle = "Cate1" });
                ctx.SaveChanges();
                ctx.Produits.Add(new Produit { Actif = true, Code = 1, Libelle = "Prod", Desc = "un produit", Prix = 2, Stock = 2, Categorie = ctx.Categories.FirstOrDefault(), CategorieId = ctx.Categories.FirstOrDefault().Id });
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
