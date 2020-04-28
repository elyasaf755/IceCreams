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
        public List<StoreListItemViewModel> Items { get; set; } = new List<StoreListItemViewModel>();

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
            //TODO: Remove this call
            PopulateItems();

            await Task.Delay(1);
        } 

        #endregion

        //TODO: Remove this
        private void PopulateItems()
        {

            CurrentStore = new Store
            {
                Name = "My Store",
                Address = new Address
                {
                    Street = "Sufa 4",
                    City = "Beit El",
                    Country = "Israel",
                },

                ImageUrl = @"pack://application:,,,/images/shop1.png",
                Phone = "0546401267",
                Icecreams = new List<Icecream>
                {
                    new Icecream
                    {
                        Name = "icecream 1",
                        ImageUrl = @"pack://application:,,,/images/shop1.jpg",
                        Description = "my icecream 1",
                        Price = "10",
                    },
                    new Icecream
                    {
                        Name = "icecream 2",
                        ImageUrl = @"pack://application:,,,/images/items/icecream_item2.jpg",
                        Description = "my icecream 2",
                        Price = "20",
                    },
                    new Icecream
                    {
                        Name = "icecream 3",
                        ImageUrl = @"pack://application:,,,/images/items/icecream_item3.jpg",
                        Description = "my icecream 3",
                        Price = "30",
                    },
                    new Icecream
                    {
                        Name = "icecream 3",
                        ImageUrl = @"pack://application:,,,/images/items/icecream_item3.jpg",
                        Description = "my icecream 4",
                        Price = "40",
                    },
                },
            };

            if (CurrentStore == null || CurrentStore.Icecreams == null)
                return;

            foreach (Icecream icecream in CurrentStore.Icecreams)
            {
                Items.Add(new StoreListItemViewModel
                {
                    Name = icecream.Name,
                    ImageUrl = icecream.ImageUrl,
                    Description = icecream.Description,
                    Price = icecream.Price,
                });
            }
        }
    }
}
