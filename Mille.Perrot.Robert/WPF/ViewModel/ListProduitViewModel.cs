using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WPF.ViewModel.Common;
using Biblio.Model.Entities;
using BusinessLayer;
using System.Windows.Input;

namespace WPF.ViewModel
{
    class ListProduitViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailProduitViewModel> _produits = null;
        private DetailProduitViewModel _selectedProd;
        private string _filter;
        private RelayCommand _code;

        #endregion

        #region Constructeurs

        public ListProduitViewModel()
        {
            _produits = new ObservableCollection<DetailProduitViewModel>();
            foreach(Produit p in Manager.Instance.GetAllProduit())
            {
                _produits.Add(new DetailProduitViewModel(p));
            }
            if (_produits != null && _produits.Count > 0)
                _selectedProd = _produits.ElementAt(0);
        }

        #endregion

        #region DataBindings

        public ObservableCollection<DetailProduitViewModel> Produits
        {
            get { return _produits; }
            set
            {
                _produits = value;
                OnPropertyChanged("Produits");
            }
        }

        public string Filter
        {
            get { return _filter; }
            set { _filter = value; }
        }

        public DetailProduitViewModel SelectedProduit
        {
            get { return _selectedProd; }
            set
            {
                _selectedProd = value;
                OnPropertyChanged("SelectedProduit");
            }
        }

        #endregion

        public ICommand FilterCode
        {
            get
            {
                if (_code == null)
                    _code = new RelayCommand(() => this.FilterOperation());
                return _code;
            }
        }

        public void FilterOperation()
        {
            _produits = new ObservableCollection<DetailProduitViewModel>();
            foreach (Produit p in Manager.Instance.GetProduitByLib(_filter))
            {
                _produits.Add(new DetailProduitViewModel(p));
            }
            if (_produits != null && _produits.Count > 0)
                _selectedProd = _produits.ElementAt(0);
        }
    }
}
