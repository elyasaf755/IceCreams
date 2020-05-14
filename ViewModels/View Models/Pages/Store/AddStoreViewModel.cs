using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public HorizontalListItemViewModel Item { get; set; } = new HorizontalListItemViewModel
        {
            UpperHeader = "BLA",
        };

        public string ImagePath { get; set; }


        #endregion

        #region Commands

        /// <summary>
        /// Fired when the store name is changed in the filters
        /// </summary>
        public ICommand StoreNameChangedCommand { get; set; }

        /// <summary>
        /// Fired whent the country is changed in the filters
        /// </summary>
        public ICommand CountryChangedCommand { get; set; }

        /// <summary>
        /// Fired when the city is changed in the filters
        /// </summary>
        public ICommand CityChangedCommand { get; set; }

        /// <summary>
        /// Fired when the street is changed in the filters
        /// </summary>
        public ICommand StreetChangedCommand { get; set; }

        /// <summary>
        /// Fired when the phone number is changed in the filters
        /// </summary>
        public ICommand PhoneNumberChangedCommand { get; set; }

        #endregion

        #region Constructor

        public AddStoreViewModel()
        {
            PopulateStore();

            //Initialize commands
            StoreNameChangedCommand = new RelayCommand(() => StoreNameChanged());
            CountryChangedCommand = new RelayCommand(() => CountryChanged());
            CityChangedCommand = new RelayCommand(() => CityChanged());
            StreetChangedCommand = new RelayCommand(() => StreetChanged());
            PhoneNumberChangedCommand = new RelayCommand(() => PhoneNumberChanged());
        }

        private void StoreNameChanged()
        {

        }

        private void StreetChanged()
        {

        }

        private void CityChanged()
        {

        }

        private void CountryChanged()
        {

        }

        private void PhoneNumberChanged()
        {

        }

        #endregion

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
