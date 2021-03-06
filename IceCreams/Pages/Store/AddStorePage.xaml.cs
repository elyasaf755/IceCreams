﻿using Models;
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
    /// Interaction logic for AddStorePage.xaml
    /// </summary>
    public partial class AddStorePage : PageBase<AddStoreViewModel>
    {
        public AddStorePage()
        {
            InitializeComponent();
        }

        public AddStorePage(ViewModelBase viewModelBase) : base(GetViewModel(viewModelBase))
        {
            InitializeComponent();
        }

        private void IcecreamDropZone_DragOver(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ((AddStoreViewModel)this.DataContext).IcecreamImageUrl = files[0];
        }

        private void StoreDropZone_DragOver(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ((AddStoreViewModel)this.DataContext).StoreImageUrl = files[0];
        }

        private static AddStoreViewModel GetViewModel(ViewModelBase viewModelBase)
        {
            if (viewModelBase is HorizontalListStoreViewModel)
            {
                HorizontalListStoreViewModel vm = viewModelBase as HorizontalListStoreViewModel;
                Address address = StringToAddress(vm.Description);
                return new AddStoreViewModel()
                {
                    CurrentStoreListViewModel = vm.MyStoreViewModel.CurrentStoreListViewModel,
                    StoreName = vm.UpperHeader,
                    StoreStreet = address.Street,
                    StoreCity = address.City,
                    StoreCountry = address.Country,
                    StoreImageUrl = vm.ImageUrl,
                    StorePhone = vm.LowerHeader,
                };
            }
            else
                return new AddStoreViewModel();
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
