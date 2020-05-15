using System.Collections.ObjectModel;

namespace ViewModels
{
    /// <summary>
    /// The StoreListDesignModel data for <see cref="HorizontalListViewModel"/>
    /// </summary>
    public class HorizontalListDesignModel : HorizontalListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static HorizontalListDesignModel Instance => new HorizontalListDesignModel();

        #endregion

        #region Constructor

        public HorizontalListDesignModel()
        {
            Items = new ObservableCollection<HorizontalListItemViewModel>
            {
                new HorizontalListPricedItemViewModel
                {
                    UpperHeader = "Store List Design Model 1",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                    Description = "Item Description 1",
                    LowerHeader = "10"
                },

                new HorizontalListPricedItemViewModel
                {
                    UpperHeader = "Store List Design Model 2",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                    Description = "Item Description 2",
                    LowerHeader = "20"
                },

                new HorizontalListPricedItemViewModel
                {
                    UpperHeader = "Store List Design Model 3",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                    Description = "Item Description 3",
                    LowerHeader = "30"
                },

                new HorizontalListPricedItemViewModel
                {
                    UpperHeader = "Store List Design Model 4",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item4.jpg",
                    Description = "Item Description 4",
                    LowerHeader = "30"
                },
            };
        } 

        #endregion
    }
}
