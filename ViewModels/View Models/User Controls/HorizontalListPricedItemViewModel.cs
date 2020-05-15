using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HorizontalListPricedItemViewModel : HorizontalListItemViewModel
    {
        #region Private Properties

        private string _price;

        #endregion

        #region Public Properties

        public override string LowerHeader
        {
            get => (_price == null || _price == string.Empty) ? string.Empty : string.Format("${0}", _price);
            set => _price = value;
        }

        #endregion
    }
}
