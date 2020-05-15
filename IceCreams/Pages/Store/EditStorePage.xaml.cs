using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModels;

namespace IceCreams
{
    /// <summary>
    /// Interaction logic for EditStorePage.xaml
    /// </summary>
    public partial class EditStorePage : PageBase<EditStoreViewModel>
    {
        public EditStorePage()
        {
            InitializeComponent();
        }

        public EditStorePage(ViewModelBase viewModelBase) : base(GetViewModel(viewModelBase))
        {
            InitializeComponent();
        }

        private void IcecreamDropZone_DragOver(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ((EditStoreViewModel)this.DataContext).IcecreamImageUrl = files[0];
        }

        private void StoreDropZone_DragOver(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ((EditStoreViewModel)this.DataContext).StoreImageUrl = files[0];
        }

        private static EditStoreViewModel GetViewModel(ViewModelBase viewModelBase)
        {
            if (viewModelBase is HorizontalListStoreViewModel)
            {
                return new EditStoreViewModel(viewModelBase as HorizontalListStoreViewModel);
            }
            else
                return new EditStoreViewModel();
        }

        private static Address StringToAddress(string address)
        {
            string[] words = address.Split(',');
            return new Address()
            {
                Street = words[0].Trim(),
                City = words[1].Trim(),
                Country = words[2].Trim(),
            };
        }
    }
}
