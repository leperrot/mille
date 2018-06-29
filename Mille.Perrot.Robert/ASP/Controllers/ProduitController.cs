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

        public ActionResult Detail(int id)
        {
            Produit prod = Manager.Instance.GetProduit(id);
            List<Categorie> cate = Manager.Instance.GetAllCategorie();
            List<SelectListItem> list = new List<SelectListItem>();
            SelectListItem sel = new SelectListItem();
            foreach(Categorie c in cate)
            {
                SelectListItem item = new SelectListItem()
                {
                    Text = c.Libelle,
                    Value = c.Id.ToString(),
                    Selected = (prod.CategorieId == c.Id)
                };
                list.Add(item);
                if (item.Selected) sel = item;
            }
            ProdCateViewModels model = new ProdCateViewModels { Prod = prod, Cate = list, SelectedCate = sel };
            return View(model);
        }

        [HttpPost]
        public ActionResult Modif(ProdCateViewModels m)
        {
            if (ModelState.IsValid)
            {
                string cId = m.SelectedCate.Value;
                Categorie c = Manager.Instance.GetCategorie(int.Parse(cId));
                m.Prod.Categorie = c;
                m.Prod.CategorieId = c.Id;
                Manager.Instance.ModifierProduit(m.Prod);
                return View("List", Manager.Instance.GetAllProduit());
            }
            return View("Detail", m.Prod.Id);
        }

        public ActionResult Ajouter()
        {
            Produit prod = new Produit();
            List<Categorie> cate = Manager.Instance.GetAllCategorie();
            List<SelectListItem> list = new List<SelectListItem>();
            SelectListItem sel = new SelectListItem();
            foreach (Categorie c in cate)
            {
                list.Add(new SelectListItem()
                {
                    Text = c.Libelle,
                    Value = c.Id.ToString(),
                    Selected = false
                });
            }
            list.ElementAt(0).Selected = true;
            sel = list.ElementAt(0);
            ProdCateViewModels model = new ProdCateViewModels { Prod = prod, Cate = list, SelectedCate = sel };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(ProdCateViewModels m)
        {
            if (ModelState.IsValid)
            {
                string cId = m.SelectedCate.Value;
                Categorie c = Manager.Instance.GetCategorie(int.Parse(cId));
                m.Prod.Categorie = c;
                m.Prod.CategorieId = c.Id;
                Manager.Instance.AjouterProduit(m.Prod);
                return View("List", Manager.Instance.GetAllProduit());
            }
            return View("Detail", m.Prod.Id);
        }
    }
}