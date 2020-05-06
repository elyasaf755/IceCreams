using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ViewModels
{
    /// <summary>
    /// The StoreListDesignModel data for <see cref="StoreListViewModel"/>
    /// </summary>
    public class StoreListDesignModel : StoreListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static StoreListDesignModel Instance => new StoreListDesignModel();

        #endregion

        #region Constructor

        public StoreListDesignModel()
        {
            Items = new ObservableCollection<StoreListItemViewModel>
            {
                new StoreListItemViewModel
                {
                    Name = "Store List Design Model 1",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                    Description = "Item Description 1",
                    Price = "10"
                },

                new StoreListItemViewModel
                {
                    Name = "Store List Design Model 2",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                    Description = "Item Description 2",
                    Price = "20"
                },

                new StoreListItemViewModel
                {
                    Name = "Store List Design Model 3",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                    Description = "Item Description 3",
                    Price = "30"
                },
            };
        } 

        #endregion
    }
}
