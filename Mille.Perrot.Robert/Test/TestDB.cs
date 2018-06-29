using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblio.Model;
using Biblio.Model.Entities;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestDB
    {
        [TestMethod]
        public void TestAjout()
        {
            Context ctx = new Context();
            ctx.Categories.Add(new Categorie { Libelle = "Cat 1", Actif = true });
            ctx.SaveChanges();
            Assert.IsNotNull(ctx.Categories.Where(c => c.Libelle == "Cat 1").FirstOrDefault());
        }

        [TestMethod]
        public void TestModif()
        {
            Context ctx = new Context();
            ctx.Categories.Add(new Categorie { Libelle = "Cat 1", Actif = true });
            ctx.SaveChanges();
            int id = ctx.Categories.Where(c => c.Libelle == "Cat 1").FirstOrDefault().Id;
            ctx.Categories.Where(c => c.Id == id).FirstOrDefault().Libelle = "MOOOODDDDIIIIIFF";
            ctx.SaveChanges();
            Assert.AreEqual(ctx.Categories.Where(c => c.Id == id).FirstOrDefault().Libelle, "MOOOODDDDIIIIIFF");
        }

        [TestMethod]
        public void TestSuppression()
        {
            Context ctx = new Context();
            ctx.Categories.Add(new Categorie { Libelle = "Cat 1", Actif = true });
            ctx.SaveChanges();
            int id = ctx.Categories.Where(c => c.Libelle == "Cat 1").FirstOrDefault().Id;
            ctx.Categories.Remove(ctx.Categories.Where(c => c.Id == id).FirstOrDefault());
            ctx.SaveChanges();
            Assert.IsNull(ctx.Categories.Where(c => c.Id == id).FirstOrDefault());
        }

        [TestMethod]
        public void TestList()
        {
            Context ctx = new Context();
            ctx.Categories.Add(new Categorie { Libelle = "Cat 1", Actif = true });
            ctx.Categories.Add(new Categorie { Libelle = "Cat 2", Actif = true });
            ctx.SaveChanges();
            List<Categorie> l = ctx.Categories.ToList();
            //Assert.IsInstanceOfType(l, Type.GetType("System.Collections.Generic.List"));
            Assert.AreEqual(l.Count(), 2);
        }
    }
}
