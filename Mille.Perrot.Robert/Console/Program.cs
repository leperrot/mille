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

                Categorie c = new Categorie { Actif = true, Libelle = "Cate1" };
                Categorie c2 = new Categorie { Actif = true, Libelle = "Cate2" };
                ctx.Categories.Add(c);
                ctx.Categories.Add(c2);
                ctx.SaveChanges();

                List<Categorie> cates = ctx.Categories.ToList();

                Produit p = new Produit { Actif = true, Code = 1, Libelle = "Prod", Desc = "un produit", Prix = 2, Stock = 8, Categorie = cates.ElementAt(0), CategorieId = cates.ElementAt(0).Id };
                Produit p2 = new Produit { Actif = true, Code = 254, Libelle = "Tong", Desc = "une tong", Prix = 4.54, Stock = 1, Categorie = cates.ElementAt(0), CategorieId = cates.ElementAt(0).Id };
                Produit p3 = new Produit { Actif = true, Code = 73, Libelle = "Livre", Desc = "un livre cool", Prix = 85.00, Stock = 100, Categorie = cates.ElementAt(0), CategorieId = cates.ElementAt(0).Id };
                Produit p4 = new Produit { Actif = true, Code = 95, Libelle = "Sac", Desc = "un sac pour mettre des trucs", Prix = 12, Stock = 3, Categorie = cates.ElementAt(0), CategorieId = cates.ElementAt(0).Id };
                Produit p5 = new Produit { Actif = true, Code = 1654, Libelle = "Gros Sac", Desc = "un plus gros sac pour mettre plus de trucs", Prix = 24, Stock = 5, Categorie = cates.ElementAt(1), CategorieId = cates.ElementAt(1).Id };
                Produit p6 = new Produit { Actif = true, Code = 888, Libelle = "Téléphone", Desc = "un téléphone pour communiquer", Prix = 199.99, Stock = 2, Categorie = cates.ElementAt(1), CategorieId = cates.ElementAt(1).Id };
                Produit p7 = new Produit { Actif = true, Code = 666, Libelle = "Bouteille", Desc = "une bouteille pour boire des trucs", Prix = 5, Stock = 0, Categorie = cates.ElementAt(1), CategorieId = cates.ElementAt(1).Id };
                Produit p8 = new Produit { Actif = true, Code = 5, Libelle = "Vodka", Desc = "pour finir arraché", Prix = 10.25, Stock = 100, Categorie = cates.ElementAt(1), CategorieId = cates.ElementAt(1).Id };
                Produit p9 = new Produit { Actif = true, Code = 789, Libelle = "Clope", Desc = "une cigarette", Prix = 0.50, Stock = 20, Categorie = cates.ElementAt(0), CategorieId = cates.ElementAt(0).Id };
                Produit p10 = new Produit { Actif = true, Code = 36, Libelle = "Souris", Desc = "une souris verte", Prix = 65.24, Stock = 10, Categorie = cates.ElementAt(0), CategorieId = cates.ElementAt(0).Id };
                ctx.Produits.Add(p);
                ctx.Produits.Add(p2);
                ctx.Produits.Add(p3);
                ctx.Produits.Add(p4);
                ctx.Produits.Add(p5);
                ctx.Produits.Add(p6);
                ctx.Produits.Add(p7);
                ctx.Produits.Add(p8);
                ctx.Produits.Add(p9);
                ctx.Produits.Add(p10);
                ctx.SaveChanges();

                Statut s = new Statut { Libelle = "Passée"};
                Statut s2 = new Statut { Libelle = "Envoyée"};
                ctx.Statuts.Add(s);
                ctx.Statuts.Add(s2);
                ctx.SaveChanges();

                Client cl = new Client { Actif = true, Nom = "ROBERT", Prenom = "Alexis" };
                Client cl2 = new Client { Actif = true, Nom = "DETAX", Prenom = "Tangal" };
                Client cl3 = new Client { Actif = true, Nom = "CAIIAL", Prenom = "Alex" };
                ctx.Clients.Add(cl);
                ctx.Clients.Add(cl2);
                ctx.Clients.Add(cl3);
                ctx.SaveChanges();

                List<Client> cli = ctx.Clients.ToList();
                List<Statut> stat = ctx.Statuts.ToList();

                Commande co = new Commande { Client = cli.ElementAt(0), ClientId = cli.ElementAt(0).Id, Statut = stat.ElementAt(0), StatutId = stat.ElementAt(0).Id, DateCommande = DateTime.Now, Observation = "WOOOOW" };
                Commande co2 = new Commande { Client = cli.ElementAt(1), ClientId = cli.ElementAt(1).Id, Statut = stat.ElementAt(1), StatutId = stat.ElementAt(1).Id, DateCommande = DateTime.Now, Observation = "WOOOOW" };
                Commande co3 = new Commande { Client = cli.ElementAt(2), ClientId = cli.ElementAt(2).Id, Statut = stat.ElementAt(0), StatutId = stat.ElementAt(0).Id, DateCommande = DateTime.Now, Observation = "WOOOOW" };
                Commande co4 = new Commande { Client = cli.ElementAt(0), ClientId = cli.ElementAt(0).Id, Statut = stat.ElementAt(1), StatutId = stat.ElementAt(1).Id, DateCommande = DateTime.Now, Observation = "WOOOOW" };
                Commande co5 = new Commande { Client = cli.ElementAt(1), ClientId = cli.ElementAt(1).Id, Statut = stat.ElementAt(0), StatutId = stat.ElementAt(0).Id, DateCommande = DateTime.Now, Observation = "WOOOOW" };
                Commande co6 = new Commande { Client = cli.ElementAt(2), ClientId = cli.ElementAt(2).Id, Statut = stat.ElementAt(1), StatutId = stat.ElementAt(1).Id, DateCommande = DateTime.Now, Observation = "WOOOOW" };
                Commande co7 = new Commande { Client = cli.ElementAt(0), ClientId = cli.ElementAt(0).Id, Statut = stat.ElementAt(0), StatutId = stat.ElementAt(0).Id, DateCommande = DateTime.Now, Observation = "WOOOOW" };
                Commande co8 = new Commande { Client = cli.ElementAt(1), ClientId = cli.ElementAt(1).Id, Statut = stat.ElementAt(1), StatutId = stat.ElementAt(1).Id, DateCommande = DateTime.Now, Observation = "WOOOOW" };
                ctx.Commandes.Add(co);
                ctx.Commandes.Add(co2);
                ctx.Commandes.Add(co3);
                ctx.Commandes.Add(co4);
                ctx.Commandes.Add(co5);
                ctx.Commandes.Add(co6);
                ctx.Commandes.Add(co7);
                ctx.Commandes.Add(co8);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
