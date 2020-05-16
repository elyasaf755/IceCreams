﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    public class StoreViewModel : ViewModelBase
    {
        #region Private Properties

        private Store _currentStore;

        #endregion

        #region Public Properties

        /// <summary>
        /// The store that the user is currently viewing
        /// </summary>
        public Store CurrentStore
        {
            get => _currentStore;
            set
            {
                _currentStore = value;
                PopulateItems();
            }
        }

        /// <summary>
        /// The view model for the HorizontalListControl, It holds all of the store's items.
        /// </summary>
        public HorizontalListViewModel CurrentStoreListViewModel { get; set; } = new HorizontalListViewModel();

        #endregion

        #region Commands

        public ICommand LeaveCommand { get; set; }

        #endregion

        #region Public Constructor

        public StoreViewModel()
        {
            LeaveCommand = new RelayCommand(() => Leave());
        }

        #endregion

        #region Private Methods

        private void PopulateItems()
        {
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

        private void Leave()
        {
            IoC.Application.GoToPage(ApplicationPage.MainPage);
        }

        #endregion

        //TODO: Delete
        private void PopulateStore()
        {

            CurrentStore = new Store
            {
                Name = "Store View Model",
                Address = new Address
                {
                    Street = "Street",
                    City = "City",
                    Country = "Country",
                },

                ImageUrl = @"/IceCreams;component/Images/shop4.png",
                Phone = "Phone Number",
                Icecreams = new List<Icecream>
                {
                    new Icecream
                    {
                        Name = "Store View Model 1",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                        Description = "Item 1",
                        Price = "10",
                    },
                    new Icecream
                    {
                        Name = "Store View Model 2",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                        Description = "Item 2",
                        Price = "20",
                    },
                    new Icecream
                    {
                        Name = "Store View Model 3",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                        Description = "Item 3",
                        Price = "30",
                    },
                    new Icecream
                    {
                        Name = "Store View Model 4",
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

            //CurrentStoreListViewModel.Items = Items;
        }
    }
}
