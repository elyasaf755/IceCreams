using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region Private Fields

        private ObservableCollection<HorizontalListStoreViewModel> _originalSource;
        private string _country;
        private string _city;
        private string _storeName;

        #endregion

        #region Public Properties

        /// <summary>
        /// List of all the stores
        /// </summary>
        public List<Store> StoresList { get; set; }

        /// <summary>
        /// Each item is a store
        /// </summary>
        public ObservableCollection<HorizontalListStoreViewModel> Items { get; set; } = new ObservableCollection<HorizontalListStoreViewModel>();

        /// <summary>
        /// The current selected store
        /// </summary>
        public HorizontalListStoreViewModel SelectedStore { get; set; }

        /// <summary>
        /// The name of the store the user is looking for
        /// </summary>
        public string StoreName
        {
            get => _storeName;
            set
            {
                _storeName = value;
                this.FilterItems();
            }
        }

        /// <summary>
        /// The country where the user is looking for stores in
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                this.FilterItems();
            }
        }

        /// <summary>
        /// The city where the user is looking for stores in
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                this.FilterItems();
            }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Fired when the page is loaded
        /// </summary>
        public ICommand LoadedCommand { get; set; }

        /// <summary>
        /// Fired when the user double clicked a store
        /// </summary>
        public ICommand OnStoreDoubleClickCommand { get; set; }

        /// <summary>
        /// Fired when store selection changed
        /// </summary>
        public ICommand SelectedStoreChangedCommand { get; set; }

        /// <summary>
        /// Fired when the user clicked the Add a New Store button
        /// </summary>
        public ICommand AddNewStoreCommand { get; set; }

        /// <summary>
        /// Fired when the user clicked the Add a New Store button
        /// </summary>
        public ICommand EditCurrentStoreCommand { get; set; }

        /// <summary>
        /// Fired when the user clicked the Add a New Store button
        /// </summary>
        public ICommand DeleteCurrentStoreCommand { get; set; }

        #endregion

        #region Public Constructor

        public MainPageViewModel()
        {
            PopulateStores(DataSource.StoresList);

            // Create commands
            LoadedCommand = new RelayCommand(() => Loaded());
            SelectedStoreChangedCommand = new RelayParameterizedCommand((parameter) => SelectedStoreChanged(ref parameter));
            OnStoreDoubleClickCommand = new RelayCommand(() => OnStoreDoubleClick());
            AddNewStoreCommand = new RelayCommand(() => AddNewStore());
            EditCurrentStoreCommand = new RelayCommand(() => EditCurrentStore());
            DeleteCurrentStoreCommand = new RelayCommand(() => DeleteCurrentStore());

            this._originalSource = this.Items;
        }

        #endregion

        #region Async Methods

        /// <summary>
        /// The logic for LoadedCommand
        /// </summary>
        /// <returns></returns>
        public void Loaded()
        {
            //PopulateStores();
        }

        /// <summary>
        /// The logic for <see cref="SelectedStoreChangedCommand"/>
        /// </summary>
        /// <returns></returns>
        public void SelectedStoreChanged(ref object sender)
        {
            if (sender == null)
                return;

            if (!(sender is HorizontalListStoreViewModel))
                return;

            SelectedStore = sender as HorizontalListStoreViewModel;
        }

        /// <summary>
        /// The logic for <see cref="OnStoreDoubleClickCommand"/>
        /// </summary>
        /// <returns></returns>
        public void OnStoreDoubleClick()
        {
            IoC.Application.GoToPage(ApplicationPage.Store, SelectedStore);
        }

        /// <summary>
        /// Takes the user to the AddStorePage
        /// </summary>
        private void AddNewStore()
        {
            IoC.Application.GoToPage(ApplicationPage.AddStore);
        }

        private void EditCurrentStore()
        {
            IoC.Application.GoToPage(ApplicationPage.EditStore, SelectedStore);
        }

        private void DeleteCurrentStore()
        {
            Store store = DataSource.StoresList.Find((x) => x.StoreId == SelectedStore.MyStoreViewModel.CurrentStore.StoreId);
            StoresList.Remove(store);
            HorizontalListStoreViewModel vm = Items.ToList().Find((x) => x.MyStoreViewModel.CurrentStore.StoreId == SelectedStore.MyStoreViewModel.CurrentStore.StoreId);
            Items.Remove(vm);
        }

        #endregion

        #region Private Methods

        private void FilterItems()
        {
            var items = this._originalSource.ToList().Where(
                p => (string.IsNullOrEmpty(this.StoreName) || p.UpperHeader.ToLower().Contains(this.StoreName.ToLower()))
                     && (string.IsNullOrEmpty(this.City) || p.Description.Split(',')[1].ToLower().Contains(this.City.ToLower()))
                     && (string.IsNullOrEmpty(this.Country) || p.Description.Split(',')[2].ToLower().Contains(this.Country.ToLower()))).ToList();

            Items = new ObservableCollection<HorizontalListStoreViewModel>(items);
        }

        private void PopulateStores(List<Store> storesList)
        {
            StoresList = storesList;

            if (StoresList == null)
                return;

            foreach (Store store in StoresList)
            {
                this.Items.Add(new HorizontalListStoreViewModel()
                {
                    UpperHeader = store.Name,
                    ImageUrl = store.ImageUrl,
                    Description = store.Address.ToString(),
                    LowerHeader = store.Phone,
                    MyStoreViewModel = new StoreViewModel()
                    {
                        CurrentStore = store,
                    }
                });
            }
        }

        #endregion

        //TODO: DELETE BEFORE DEPLOY
        #region DELETE BEFORE DEPLOY

        private List<HorizontalListItemViewModel> GetStoreItems(Store store)
        {
            var result = new List<HorizontalListItemViewModel>();
            foreach (Icecream icecream in store.Icecreams)
            {
                result.Add(new HorizontalListItemViewModel
                {
                    UpperHeader = icecream.Name,
                    ImageUrl = icecream.ImageUrl,
                    Description = icecream.Description,
                    LowerHeader = icecream.Price,
                });
            }

            return result;
        }

        #endregion
    }
}
