using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HorizontalListViewModel : ViewModelBase
    {
        #region Public Properties
        /// <summary>
        /// The items list
        /// </summary>
        public List<HorizontalListItemViewModel> Items { get; set; }

        #endregion

        public HorizontalListViewModel()
        {
            
        }
    }
}
