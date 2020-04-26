using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StoreDesignViewModel : StoreViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static StoreDesignViewModel Instance => new StoreDesignViewModel();

        #endregion

        public StoreDesignViewModel()
        {
            CurrentStore = new Store
            {
                Name = "My Store",
                PictureUrl = @"pack://application:,,,/Images/shop3.png",
                Address = new Address
                {
                    Country = "Israel",
                    City = "Jerusalem",
                    Street = "Jaffa 70",
                },
            };
        }
    }
}
