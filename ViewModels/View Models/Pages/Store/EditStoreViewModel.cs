
using Models;
using System;
using System.Windows.Input;

namespace ViewModels
{
    public class EditStoreViewModel : StoreEditorBaseViewModel
    {

        #region Commands

        public ICommand ApplyChangesCommand { get; set; }

        #endregion

        #region Constructor

        public EditStoreViewModel()
        {
            ApplyChangesCommand = new RelayCommand(() => ApplyChanges());
        }

        public EditStoreViewModel(HorizontalListStoreViewModel viewModel) : base(viewModel.MyStoreViewModel.CurrentStore.StoreId)
        {
            ApplyChangesCommand = new RelayCommand(() => ApplyChanges());

            Address address = StringToAddress(viewModel.Description);

            CurrentStoreListViewModel = viewModel.MyStoreViewModel.CurrentStoreListViewModel;
            StoreName = viewModel.UpperHeader;
            StoreStreet = address.Street;
            StoreCity = address.City;
            StoreCountry = address.Country;
            StoreImageUrl = viewModel.ImageUrl;
            StorePhone = viewModel.LowerHeader;
        }

        #endregion

        #region Private Methods

        private void ApplyChanges()
        {
            UpdateStore();

            IoC.Application.GoToPage(ApplicationPage.MainPage);
        }

        private void UpdateStore()
        {
            Store store = DataSource.StoresList.Find((x) => x.StoreId == CurrentStore.StoreId);

            store.Name = StoreName;
            store.ImageUrl = StoreImageUrl;
            store.Phone = StorePhone;
            store.Address.Street = StoreStreet;
            store.Address.City = StoreCity;
            store.Address.Country = StoreCountry;
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

        #endregion
    }
}
