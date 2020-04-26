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
        public StoreDesignViewModel()
        {
            CurrentStore = new Store
            {
                Address = new Address
                {
                    Country = "Israel",
                    City = "Jerusalem",
                    Street = "Jaffa 70",
                },
                Name = "Scoops",
                PictureUrl = @"pack:application,,,/Images/shop3.png",
            };
        }
    }
}
