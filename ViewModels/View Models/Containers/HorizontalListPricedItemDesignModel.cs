using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HorizontalListPricedItemDesignModel : HorizontalListPricedItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static HorizontalListDesignModel Instance => new HorizontalListDesignModel();

        #endregion

        #region Constructor

        public HorizontalListPricedItemDesignModel()
        {

        }

        #endregion
    }
}
