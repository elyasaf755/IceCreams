using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HorizontalListItemViewModel : ViewModelBase
    {
        #region Public Properties

        public virtual string UpperHeader { get; set; }
        public virtual string ImageUrl { get; set; }
        public virtual string Description { get; set; }
        public virtual string LowerHeader { get; set; }

        #endregion
    }
}
