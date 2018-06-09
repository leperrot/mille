using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using Biblio.Model.Entities;

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
            return View(prod);
        }
    }
}