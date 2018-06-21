using Biblio.Model.Entities;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModel.Common;

namespace WPF.ViewModel
{
    class DetailProduitViewModel : BaseViewModel
    {
        #region Variables

        private Produit _produit;
        private RelayCommand _modify;

        #endregion

        #region Constructeurs

        public DetailProduitViewModel(Produit p)
        {
            this._produit = p;
        }

        #endregion

        #region DataBindings

        public long Code
        {
            get { return _produit.Code; }
            set { _produit.Code = value; }
        }

        public string Desc
        {
            get { return _produit.Desc; }
            set { _produit.Desc = value; }
        }

        public string Libelle
        {
            get { return _produit.Libelle; }
            set { _produit.Libelle = value; }
        }

        public int Stock
        {
            get { return _produit.Stock; }
            set { _produit.Stock = value; }
        }

        public double Prix
        {
            get { return _produit.Prix; }
            set { _produit.Prix = value; }
        }

        #endregion

        #region Commandes

        /*public ICommand AddOperation
        {
            get
            {
                if (_add == null)
                    _add = new RelayCommand(() => this.ShowWindowOperation());
                return _add;
            }
        }
        
        public void ShowWindowOperation()
        {
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }*/

        #endregion
    }
}
