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

        /// <summary>
        /// Item's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Item's image path
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Item's description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Item's price
        /// </summary>
        public string Price
        {
            get => _price == null? null : string.Format("${0}", _price);
            set => _price = value;
        }

        #endregion
    }
}
