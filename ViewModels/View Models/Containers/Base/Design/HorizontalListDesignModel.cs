using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HorizontalListDesignModel : HorizontalListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static HorizontalListDesignModel Instance => new HorizontalListDesignModel();

        #endregion

        #region Constructor

        public HorizontalListDesignModel()
        {
            Items = new List<HorizontalListItemViewModel>()
            {
                new HorizontalListItemViewModel
                {
                    UpperHeader = "Horizontal List Design Model 1",
                    ImageUrl = @"/IceCreams;component/Images/shop1.png",
                    Description = "Design-Time Description",
                    LowerHeader = "Design-Time Lower Header",
                },

                new HorizontalListItemViewModel
                {
                    UpperHeader = "Horizontal List Design Model 2",
                    ImageUrl = @"/IceCreams;component/Images/shop2.png",
                    Description = "Design-Time Description",
                    LowerHeader = "Design-Time Lower Header",
                },

                new HorizontalListItemViewModel
                {
                    UpperHeader = "Horizontal List Design Model 3",
                    ImageUrl = @"/IceCreams;component/Images/shop3.png",
                    Description = "Design-Time Description",
                    LowerHeader = "Design-Time Lower Header",
                },

                new HorizontalListItemViewModel
                {
                    UpperHeader = "Horizontal List Design Model 3",
                    ImageUrl = @"/IceCreams;component/Images/shop3.png",
                    Description = "Design-Time Description",
                    LowerHeader = "Design-Time Lower Header",
                },

                new HorizontalListItemViewModel
                {
                    UpperHeader = "Horizontal List Design Model 3",
                    ImageUrl = @"/IceCreams;component/Images/shop3.png",
                    Description = "Design-Time Description",
                    LowerHeader = "Design-Time Lower Header",
                },

                new HorizontalListItemViewModel
                {
                    UpperHeader = "Horizontal List Design Model 3",
                    ImageUrl = @"/IceCreams;component/Images/shop3.png",
                    Description = "Design-Time Description",
                    LowerHeader = "Design-Time Lower Header",
                },

                new HorizontalListItemViewModel
                {
                    UpperHeader = "Horizontal List Design Model 3",
                    ImageUrl = @"/IceCreams;component/Images/shop3.png",
                    Description = "Design-Time Description",
                    LowerHeader = "Design-Time Lower Header",
                },

                new HorizontalListItemViewModel
                {
                    UpperHeader = "Horizontal List Design Model 3",
                    ImageUrl = @"/IceCreams;component/Images/shop3.png",
                    Description = "Design-Time Description",
                    LowerHeader = "Design-Time Lower Header",
                },

                new HorizontalListItemViewModel
                {
                    UpperHeader = "Horizontal List Design Model 3",
                    ImageUrl = @"/IceCreams;component/Images/shop3.png",
                    Description = "Design-Time Description",
                    LowerHeader = "Design-Time Lower Header",
                },
            };
        }

        #endregion
    }
}
