using Biblio.Model.Entities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Models
{
    public class ProdCateViewModels
    {
        public Produit Prod { get; set; }
        public IEnumerable<SelectListItem> Cate { get; set; }
    }
}