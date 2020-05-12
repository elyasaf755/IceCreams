using Models;
using System;
using System.Collections.Generic;

namespace ViewModels
{
    public class AddStoreViewModel : ViewModelBase
    {
        #region Public Properties

        /// <summary>
        /// The store that the user is currently adding
        /// </summary>
        public Store CurrentStore { get; set; }

        /// <summary>
        /// The view model for the HorizontalListControl, It holds all of the store's items.
        /// </summary>
        public HorizontalListViewModel CurrentStoreListViewModel { get; set; } = new HorizontalListViewModel();

        public bool IsDragDropOver { get; set; } = false;


        #endregion

        #region Constructor

        public AddStoreViewModel()
        {
            PopulateStore();
        }

        #endregion

        public void DragOver(object sender, EventArgs e)
        {
            IsDragDropOver = true;
        }

        private void PopulateStore()
        {
            CurrentStore = new Store
            {
                Name = "Store Design Model",
                Address = new Address
                {
                    Street = "Sufa 4",
                    City = "Beit El",
                    Country = "Israel",
                },

                ImageUrl = @"/IceCreams;component/Images/logo.png",
                Phone = "0546401267",

                Icecreams = new List<Icecream>
                {
                    new Icecream
                    {
                        Name = "Store Design Model 1",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                        Description = "Item 1",
                        Price = "10",
                    },
                    new Icecream
                    {
                        Name = "Store Design Model 2",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                        Description = "Item 2",
                        Price = "20",
                    },
                    new Icecream
                    {
                        Name = "Store Design Model 3",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                        Description = "Item 3",
                        Price = "30",
                    },
                    new Icecream
                    {
                        Name = "Store Design Model 4",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                        Description = "Item 4",
                        Price = "40",
                    },
                },
            };

            if (CurrentStore == null || CurrentStore.Icecreams == null)
                return;

            foreach (Icecream icecream in CurrentStore.Icecreams)
            {
                CurrentStoreListViewModel.Items.Add(new HorizontalListPricedItemViewModel
                {
                    UpperHeader = icecream.Name,
                    ImageUrl = icecream.ImageUrl,
                    Description = icecream.Description,
                    LowerHeader = icecream.Price,
                });
            }
        }
    }
}
