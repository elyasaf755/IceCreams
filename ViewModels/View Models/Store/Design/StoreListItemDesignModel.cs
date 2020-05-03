using System;
using System.Collections.Generic;


namespace ViewModels
{
    /// <summary>
    /// The design-time data for <see cref="StoreListItemViewModel"/>
    /// </summary>
    public class StoreListItemDesignModel : StoreListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static StoreListItemDesignModel Instance => new StoreListItemDesignModel();

        #endregion

        #region Constructor

        public StoreListItemDesignModel()
        {
            Name = "Store List Item Design Model";
            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg";
            Description = "Design Time Description";
            Price = "20";
        }

        #endregion
    }
}