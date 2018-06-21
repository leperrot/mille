using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.ViewModel.Common;

namespace WPF.ViewModel
{
    class HomeViewModel : BaseViewModel
    {
        #region Variables

        private ListProduitViewModel _produits = null;

        #endregion

        #region Constructeurs

        public HomeViewModel()
        {
            _produits = new ListProduitViewModel();
        }

        #endregion

        #region DataBindings

        public ListProduitViewModel ListeProduits
        {
            get { return _produits; }
            set { _produits = value; }
        }

        #endregion
    }
}
