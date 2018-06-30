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
        private Boolean _pop;
        public Boolean Pop
        {
            get { return this._pop; }
            set { this._pop = value; }
        }
        private RelayCommand _modify;
        private RelayCommand _stock;

        #endregion

        #region Constructeurs

        public DetailProduitViewModel(Produit p)
        {
            this._produit = p;
            this._pop = false;
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

        public ICommand Modify
        {
            get
            {
                if (_modify == null)
                    _modify = new RelayCommand(() => this.ModifyOperation());
                return _modify;
            }
        }

        public void ModifyOperation()
        {
            this._pop = false;
            Manager.Instance.ModifierProduit(this._produit);
        }

        public ICommand ViewStock
        {
            get
            {
                if (_stock == null)
                    _stock = new RelayCommand(() => this.StockOperation());
                return _stock;
            }
        }

        public void StockOperation()
        {
            this._pop = true;
        }

        #endregion
    }
}
