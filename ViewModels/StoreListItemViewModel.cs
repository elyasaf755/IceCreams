using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StoreListItemViewModel : ViewModelBase
    {
        #region Private Fields
        private string _price;
        #endregion

        #region Public Properties
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Price
        {
            get => string.Format("${0}", _price);
            set => _price = value;
        }
        #endregion
    }
}
