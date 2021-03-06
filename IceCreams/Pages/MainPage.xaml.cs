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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : PageBase<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Item_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender == null)
                return;

            if (!(sender is HorizontalListItemControl))
                return;

            var selectedItem = sender as HorizontalListItemControl;
            var store = selectedItem.DataContext;
        }
    }
}
