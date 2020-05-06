using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HorizontalListItemDesignModel : HorizontalListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static HorizontalListItemDesignModel Instance => new HorizontalListItemDesignModel();

        #endregion

        #region Constructor

        public HorizontalListItemDesignModel()
        {
            UpperHeader = "Horizontal List Item Design Model";
            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg";
            Description = "Design-Time Description";
            LowerHeader = "Design-Time Lower Header";
        }

        #endregion
    }
}
