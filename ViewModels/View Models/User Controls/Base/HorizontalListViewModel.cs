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
        /// <summary>
        /// The items collection
        /// </summary>
        public ObservableCollection<HorizontalListItemViewModel> Items { get; set; } = new ObservableCollection<HorizontalListItemViewModel>();

        /// <summary>
        /// Fired when the left arrow is clicked
        /// </summary>
        public ICommand LeftButtonCommand { get; set; }

        /// <summary>
        /// Fired when the right arrow is clicked
        /// </summary>
        public ICommand RightButtonCommand { get; set; }

        public HorizontalListViewModel()
        {
            LeftButtonCommand = new RelayCommand(async () => await LeftButtonClick());
            RightButtonCommand = new RelayCommand(async () => await RightButtonClick());
        }

        /// <summary>
        /// Logic for <see cref="LeftButtonCommand"/>
        /// </summary>
        /// <returns></returns>
        public async Task LeftButtonClick()
        {
            if (Items.Count == 0)
                return;

            var temp = Items[Items.Count - 1];
            Items.RemoveAt(Items.Count - 1);
            Items.Insert(0, temp);


            await Task.Delay(1);
        }

        /// <summary>
        /// Logic for <see cref="RightButtonCommand"/>
        /// </summary>
        /// <returns></returns>
        public async Task RightButtonClick()
        {
            if (Items.Count == 0)
                return;

            var temp = Items[0];
            Items.RemoveAt(0);
            Items.Add(temp);

            await Task.Delay(1);
        }
    }
}