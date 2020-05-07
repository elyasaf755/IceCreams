using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    public class StoreListViewModel : ViewModelBase
    {
        /// <summary>
        /// The items collection
        /// </summary>
        public ObservableCollection<StoreListItemViewModel> Items { get; set; } = new ObservableCollection<StoreListItemViewModel>();

        /// <summary>
        /// Fired when the left arrow is clicked
        /// </summary>
        public ICommand LeftButtonCommand { get; set; }

        /// <summary>
        /// Fired when the right arrow is clicked
        /// </summary>
        public ICommand RightButtonCommand { get; set; }

        public StoreListViewModel()
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
            var temp = Items[0];
            Items.RemoveAt(0);
            Items.Add(temp);

            await Task.Delay(1);
        }
    }
}