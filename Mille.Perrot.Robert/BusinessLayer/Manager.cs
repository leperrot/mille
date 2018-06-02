using Biblio.Model;
using Biblio.Model.Entities;
using BusinessLayer.Commands;
using BusinessLayer.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Manager
    {
        private readonly Context ctx;
        private static Manager _manager = null;

        private Manager()
        {
            ctx = new Context();
        }

        public static Manager Instance
        {
            get
            {
                if (_manager == null)
                    _manager = new Manager();
                return _manager;
            }
        }

        #region Produit

        public List<Produit> GetAllProduit()
        {
            ProduitQuery pq = new ProduitQuery(ctx);
            return pq.GetAll().ToList();
        }

        public Produit GetProduit(int id)
        {
            ProduitQuery pq = new ProduitQuery(ctx);
            Produit p;
            try
            {
                p = pq.GetByID(id).First();
            }catch(Exception e)
            {
                throw e;
            }
            return p;
        }

        public int AjouterProduit(Produit p)
        {
            ProduitCommand pc = new ProduitCommand(ctx);
            return pc.Ajouter(p);
        }

        public void ModifierProduit(Produit p)
        {
            ProduitCommand pc = new ProduitCommand(ctx);
            pc.Modifier(p);
        }

        public void SupprimerProduit(int produitID)
        {
            ProduitCommand pc = new ProduitCommand(ctx);
            pc.Supprimer(produitID);
        }

        #endregion

        #region Categorie

        public List<Categorie> GetAllCategorie()
        {
            CategorieQuery pq = new CategorieQuery(ctx);
            return pq.GetAll().ToList();
        }

        public Categorie GetCategorie(int id)
        {
            CategorieQuery pq = new CategorieQuery(ctx);
            return pq.GetCategorie(id).FirstOrDefault();
        }

        #endregion

        #region Client

        public List<Client> GetAllClient()
        {
            ClientQuery pq = new ClientQuery(ctx);
            return pq.GetAll().ToList();
        }

        public Client GetClient(int id)
        {
            ClientQuery pq = new ClientQuery(ctx);
            return pq.GetClient(id).FirstOrDefault();
        }

        #endregion

        #region Commande

        public List<Commande> GetAllCommande()
        {
            CommandeQuery pq = new CommandeQuery(ctx);
            return pq.GetAll().ToList();
        }

        public Commande GetCommande(int id)
        {
            CommandeQuery pq = new CommandeQuery(ctx);
            return pq.GetCommande(id).FirstOrDefault();
        }

        #endregion

        #region Statut

        public List<Statut> GetAllStatut()
        {
            StatutQuery pq = new StatutQuery(ctx);
            return pq.GetAll().ToList();
        }

        public Statut GetStatut(int id)
        {
            StatutQuery pq = new StatutQuery(ctx);
            return pq.GetStatut(id).FirstOrDefault();
        }

        #endregion
    }
}
