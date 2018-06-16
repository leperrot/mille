using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using Biblio.Model.Entities;
using ASP.Models;

namespace ASP.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult List()
        {
            List<Produit> prods = Manager.Instance.GetAllProduit();
            return View(prods);
        }

        public ActionResult Search(String libelle)
        {
            List<Produit> prods = Manager.Instance.GetProduitByLib(libelle);
            return View(prods);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            Produit prod = Manager.Instance.GetProduit(id);
            List<Categorie> cate = Manager.Instance.GetAllCategorie();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach(Categorie c in cate)
            {
                if(prod.CategorieId == c.Id)
                    list.Add(new SelectListItem()
                    {
                        Text = c.Libelle,
                        Value = c.Id.ToString(),
                        Selected = true
                    });
                else
                    list.Add(new SelectListItem()
                    {
                        Text = c.Libelle,
                        Value = c.Id.ToString(),
                        Selected = false
                    });
            }
            ProdCateViewModels model = new ProdCateViewModels{ Prod = prod, Cate = list };
            return View(model);
        }

        [HttpPost]
        public ActionResult Detail(ProdCateViewModels prod)
        {
            if (ModelState.IsValid)
            {
                Manager.Instance.ModifierProduit(prod.Prod);
                return View("List");
            }
            return View(prod.Prod.Id);
        }
    }
}