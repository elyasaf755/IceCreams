﻿using System;
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
    /// Interaction logic for StorePage.xaml
    /// </summary>
    public partial class StorePage : PageBase<StoreViewModel>
    {
        public StorePage()
        {
            InitializeComponent();
        }

        public StorePage(ViewModelBase viewModel) : base((viewModel as HorizontalListStoreViewModel).MyStoreViewModel)
        {
            InitializeComponent();
        }
    }
}
