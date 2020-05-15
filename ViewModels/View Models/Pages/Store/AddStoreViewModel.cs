using Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    public class AddStoreViewModel : StoreEditorBaseViewModel
    {
        #region Commands

        /// <summary>
        /// Fired when the "Add Button" is clicked
        /// </summary>
        public ICommand AddStoreCommand { get; set; }

        #endregion

        #region Constructor

        public AddStoreViewModel() : base()
        {
            AddStoreCommand = new RelayCommand(() => AddStore());
        }

        #endregion

        #region Private Methods

        private void AddStore()
        {
            if (!ValidateStoreFields())
                return;

            DataSource.StoresList.Insert(0, CurrentStore);
            IoC.Application.GoToPage(ApplicationPage.MainPage);
        }

        #endregion
    }
}
