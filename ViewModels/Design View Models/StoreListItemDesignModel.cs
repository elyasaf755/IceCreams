using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StoreListItemDesignModel : StoreListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the view model
        /// </summary>
        public static StoreListItemDesignModel Instance => new StoreListItemDesignModel();

        #endregion

        public StoreListItemDesignModel()
        {
            Name = "Choclate Icecream";
            ImageUrl = @"pack://application:,,,/images/items/icecream_item1.jpg";
            Description = "This icecream is the best there is.\nTasting it once will make you hate any other icecream.";
            Price = "23.5";
        }
    }
}
