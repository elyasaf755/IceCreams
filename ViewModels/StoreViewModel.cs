using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StoreViewModel : ViewModelBase
    {
        public Store CurrentStore { get; set; } = new Store
        {
            Name = "Scoops",
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
