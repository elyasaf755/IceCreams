using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class StoreListViewModel : ViewModelBase
    {
        public List<StoreListItemViewModel> Items { get; set; }
    }
}