using Models;
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
        #region Public Properties

        public Store CurrentStore { get; set; }
        //public List<StoreListItemViewModel> Items { get; set; } = new List<StoreListItemViewModel>();
        public StoreListViewModel CurrentStoreListViewModel { get; set; } = new StoreListViewModel();

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoadedCommand { get; set; }

        #endregion

        #region Public Constructor

        public StoreViewModel()
        {
            // Create commands
            LoadedCommand = new RelayCommand(async () => await Loaded());
        }

        #endregion


        #region Async Methods

        public async Task Loaded()
        {
            //TODO: Delete
            PopulateStore();

            await Task.Delay(1);
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
                CurrentStoreListViewModel.Items.Add(new StoreListItemViewModel
                {
                    Name = icecream.Name,
                    ImageUrl = icecream.ImageUrl,
                    Description = icecream.Description,
                    Price = icecream.Price,
                });
            }

            //CurrentStoreListViewModel.Items = Items;
        }
    }
}
