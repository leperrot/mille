using ASP.Models;
using Biblio.Model.Entities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Produit> prods = Manager.Instance.GetPreferredProduits();
            List<Commande> coms = Manager.Instance.GetLastCommandes();
            ProdCommViewModels model = new ProdCommViewModels { Prods = prods, Comms = coms };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}