using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    public class HorizontalListViewModel : ViewModelBase
    {
        #region Public Properties

        /// <summary>
        /// The items collection
        /// </summary>
        public ObservableCollection<HorizontalListItemViewModel> Items { get; set; } = new ObservableCollection<HorizontalListItemViewModel>();

        #endregion

        #region Commands

        /// <summary>
        /// Fired when the left arrow is clicked
        /// </summary>
        public ICommand LeftButtonCommand { get; set; }

        /// <summary>
        /// Fired when the right arrow is clicked
        /// </summary>
        public ICommand RightButtonCommand { get; set; }

        #endregion

        #region Constructor

        public HorizontalListViewModel()
        {
            LeftButtonCommand = new RelayCommand(() => LeftButtonClick());
            RightButtonCommand = new RelayCommand(() => RightButtonClick());
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Logic for <see cref="LeftButtonCommand"/>
        /// </summary>
        /// <returns></returns>
        public void LeftButtonClick()
        {
            if (Items.Count == 0)
                return;

            var temp = Items[Items.Count - 1];
            Items.RemoveAt(Items.Count - 1);
            Items.Insert(0, temp);
        }

        /// <summary>
        /// Logic for <see cref="RightButtonCommand"/>
        /// </summary>
        /// <returns></returns>
        public void RightButtonClick()
        {
            if (Items.Count == 0)
                return;

            var temp = Items[0];
            Items.RemoveAt(0);
            Items.Add(temp);
        }

        #endregion

    }
}