using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StoreListDesignModel : StoreListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static StoreListDesignModel Instance => new StoreListDesignModel();

        #endregion

        public StoreListDesignModel()
        {
            Items = new List<StoreListItemViewModel>
            {
                new StoreListItemViewModel
                {
                    Name = "Vanilla Icecream1",
                    ImageUrl = @"pack://application:,,,/Images/Items/icecream_item1.jpg",
                    Description = "Best vanilla1 icecream there is",
                    Price = "10.99"
                },

                new StoreListItemViewModel
                {
                    Name = "Vanilla Icecream2",
                    ImageUrl = @"pack://application:,,,/Images/Items/icecream_item2.jpg",
                    Description = "Best vanilla2 icecream there is",
                    Price = "20.99"
                },

                new StoreListItemViewModel
                {
                    Name = "Vanilla Icecream3",
                    ImageUrl = @"pack://application:,,,/Images/Items/icecream_item3.jpg",
                    Description = "Best vanilla3 icecream there is",
                    Price = "30.99"
                },
            };
        }
    }
}
