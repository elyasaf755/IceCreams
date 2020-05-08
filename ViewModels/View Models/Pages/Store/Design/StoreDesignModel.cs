using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StoreDesignModel : StoreViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static StoreDesignModel Instance => new StoreDesignModel();

        #endregion

        #region Constructor

        public StoreDesignModel()
        {
            PopulateStore();
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
