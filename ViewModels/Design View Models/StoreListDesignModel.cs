using System.Collections.Generic;

namespace ViewModels
{
    /// <summary>
    /// The design-time data for <see cref="StoreListViewModel"/>
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
            Items = new List<StoreListItemViewModel>
            {
                new StoreListItemViewModel
                {
                    Name = "Design-Time Name 1",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                    Description = "Design-Time Description 1",
                    Price = "Design-Time Price 1"
                },

                new StoreListItemViewModel
                {
                    Name = "Design-Time Name 2",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                    Description = "Design-Time Description 2",
                    Price = "Design-Time Price 2"
                },

                new StoreListItemViewModel
                {
                    Name = "Design-Time Name 3",
                    ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                    Description = "Design-Time Description 3",
                    Price = "Design-Time Price 3"
                },
            };
        } 

        #endregion
    }
}
