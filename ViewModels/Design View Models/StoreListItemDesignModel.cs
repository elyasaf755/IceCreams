using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    /// <summary>
    /// The design-time data for <see cref="StoreListItemViewModel"/>
    /// </summary>
    public class StoreListItemDesignModel : StoreListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static StoreListItemDesignModel Instance => new StoreListItemDesignModel();

        #endregion

        #region Constructor

        public StoreListItemDesignModel()
        {
            Name = "Design Time Name";
            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg";
            Description = "Design Time Description";
            Price = "Design Time Price";
        }

        #endregion
    }
}
