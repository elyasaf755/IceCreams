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
    /// Interaction logic for AddStorePage.xaml
    /// </summary>
    public partial class AddStorePage : PageBase<AddStoreViewModel>
    {
        public AddStorePage()
        {
            InitializeComponent();
        }

        private void DropArea_DragOver(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ((AddStoreViewModel)this.DataContext).Item.ImageUrl = files[0];
        }
    }
}
