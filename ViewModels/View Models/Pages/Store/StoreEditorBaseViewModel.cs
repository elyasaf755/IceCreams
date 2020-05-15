using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    /// <summary>
    /// The base view model for AddStorePage and EditStorePage
    /// </summary>
    public class StoreEditorBaseViewModel : ViewModelBase
    {
        #region Private Fields

        private string _icecreamName;
        private string _icecreamImagePath;
        private string _icecreamDescription;
        private string _icecreamPrice;
        private string _storeImageUrl;
        private string _storeName;
        private string _storeStreet;
        private string _storeCity;
        private string _storeCountry;
        private string _storePhone;

        #endregion

        #region Public Fields

        /// <summary>
        /// The id of the store the user is currently editing
        /// </summary>
        public readonly string StoreId;

        #endregion

        #region Public Properties

        /// <summary>
        /// The store model that the user is currently adding
        /// </summary>
        public Store CurrentStore { get; set; }

        /// <summary>
        /// The store's icecreams list that the view is bound to
        /// </summary>
        public HorizontalListViewModel CurrentStoreListViewModel { get; set; } = new HorizontalListViewModel();

        /// <summary>
        /// The icecream that the view is bound to
        /// </summary>
        public HorizontalListPricedItemViewModel Item { get; set; } = new HorizontalListPricedItemViewModel();

        /// <summary>
        /// Fired when store selection changed
        /// </summary>
        public ICommand SelectedIcecreamChangedCommand { get; set; }

        /// <summary>
        /// Representing the expanded expander. Used to 
        /// </summary>
        public object SelectedExpander { get; set; }

        /// <summary>
        /// The icecream's name that the user is currently adding
        /// </summary>
        public string IcecreamName
        {
            get => _icecreamName;
            set
            {
                _icecreamName = value;
                Item.UpperHeader = value;
            }
        }

        /// <summary>
        /// The icecream's image path that the user is currently adding
        /// </summary>
        public string IcecreamImageUrl
        {
            get => _icecreamImagePath;
            set
            {
                _icecreamImagePath = value;
                Item.ImageUrl = value;
            }
        }

        /// <summary>
        /// The icecream's description that the user is currently adding
        /// </summary>
        public string IcecreamDescription
        {
            get => _icecreamDescription;
            set
            {
                _icecreamDescription = value;
                Item.Description = value;
            }
        }

        /// <summary>
        /// The icecream's price that the user is currently adding
        /// </summary>
        public string IcecreamPrice
        {
            get => _icecreamPrice;
            set
            {
                //It should be "if(Regex.IsMatch(value, @"[^0-9]+"))" instead, 
                //but it seems to work only this way for some reason.
                if (!Regex.IsMatch(value, @"[^0-9]+"))
                {
                    _icecreamPrice = value;
                    Item.LowerHeader = value;
                }
            }
        }

        /// <summary>
        /// The store's logo that the user currently dragged
        /// </summary>
        public string StoreName
        {
            get => _storeName;
            set
            {
                _storeName = value;
                CurrentStore.Name = value;
            }
        }

        /// <summary>
        /// The store's logo that the user currently dragged
        /// </summary>
        public string StoreImageUrl
        {
            get => _storeImageUrl;
            set
            {
                _storeImageUrl = value;
                CurrentStore.ImageUrl = value;
            }
        }

        /// <summary>
        /// The store's street that the user currently editing
        /// </summary>
        public string StoreStreet
        {
            get => _storeStreet;
            set
            {
                _storeStreet = value;
                CurrentStore.Address.Street = value;
            }
        }

        /// <summary>
        /// The store's city that the user currently editing
        /// </summary>
        public string StoreCity
        {
            get => _storeCity;
            set
            {
                _storeCity = value;
                CurrentStore.Address.City = value;
            }
        }

        /// <summary>
        /// The store's country that the user currently editing
        /// </summary>
        public string StoreCountry
        {
            get => _storeCountry;
            set
            {
                _storeCountry = value;
                CurrentStore.Address.Country = value;
            }
        }

        /// <summary>
        /// The store's phone number that the user currently editing
        /// </summary>
        public string StorePhone
        {
            get => _storePhone;
            set
            {
                _storePhone = value;
                CurrentStore.Phone = value;
            }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Fired when the add Icecream button is clicked
        /// </summary>
        public ICommand AddIcecreamCommand { get; set; }

        /// <summary>
        /// Fired when the Edit Icecream context menu item is clicked
        /// </summary>
        public ICommand EditCurrentIcecreamCommand { get; set; }

        /// <summary>
        /// Fired when the Delete Icecream context menu item is clicked
        /// </summary>
        public ICommand DeleteCurrentIcecreamCommand { get; set; }

        /// <summary>
        /// Fired when the Leave button is clicked
        /// </summary>
        public ICommand LeaveCommand { get; set; }

        #endregion

        #region Constructors

        public StoreEditorBaseViewModel()
        {
            CurrentStore = new Store();

            //Initialize commands
            AddIcecreamCommand = new RelayCommand(() => AddIcecream());
            LeaveCommand = new RelayCommand(() => Leave());
            EditCurrentIcecreamCommand = new RelayCommand(() => EditCurrentIcecream());
            DeleteCurrentIcecreamCommand = new RelayCommand(() => DeleteCurrentIcecream());
        }

        public StoreEditorBaseViewModel(string storeId)
        {
            CurrentStore = DataSource.StoresList.Find((x) => x.StoreId == storeId);

            //Initialize commands
            AddIcecreamCommand = new RelayCommand(() => AddIcecream());
            LeaveCommand = new RelayCommand(() => Leave());
            EditCurrentIcecreamCommand = new RelayCommand(() => EditCurrentIcecream());
            DeleteCurrentIcecreamCommand = new RelayCommand(() => DeleteCurrentIcecream());
        }

        #endregion

        #region Private Methods

        protected void AddIcecream()
        {
            CurrentStore.Icecreams.Insert(0, new Icecream()
            {
                Name = IcecreamName,
                ImageUrl = IcecreamImageUrl,
                Description = IcecreamDescription,
                Price = IcecreamPrice,
            });

            CurrentStoreListViewModel.Items.Insert(0, new HorizontalListPricedItemViewModel()
            {
                UpperHeader = IcecreamName,
                ImageUrl = IcecreamImageUrl,
                Description = IcecreamDescription,
                LowerHeader = IcecreamPrice,
            });

            ClearIcecreamDetails();
        }

        private void EditCurrentIcecream()
        {
            throw new NotImplementedException();
        }

        private void DeleteCurrentIcecream()
        {
            throw new NotImplementedException();
        }

        private void Leave()
        {
            IoC.Application.GoToPage(ApplicationPage.MainPage);
        }

        protected void PopulateStore()
        {
            CurrentStore = new Store
            {
                Icecreams = new List<Icecream>
                {
                    new Icecream
                    {
                        Name = "Store Design Model 1",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                        Description = "Item 1",
                        Price = "10",
                    },
                    new Icecream
                    {
                        Name = "Store Design Model 2",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                        Description = "Item 2",
                        Price = "20",
                    },
                    new Icecream
                    {
                        Name = "Store Design Model 3",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                        Description = "Item 3",
                        Price = "30",
                    },
                    new Icecream
                    {
                        Name = "Store Design Model 4",
                        ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                        Description = "Item 4",
                        Price = "40",
                    },
                },
            };

            if (CurrentStore == null || CurrentStore.Icecreams == null)
                return;

            foreach (Icecream icecream in CurrentStore.Icecreams)
            {
                CurrentStoreListViewModel.Items.Add(new HorizontalListPricedItemViewModel
                {
                    UpperHeader = icecream.Name,
                    ImageUrl = icecream.ImageUrl,
                    Description = icecream.Description,
                    LowerHeader = icecream.Price,
                });
            }
        }

        protected void ClearIcecreamDetails()
        {
            IcecreamName = string.Empty;
            IcecreamImageUrl = string.Empty;
            IcecreamDescription = string.Empty;
            IcecreamPrice = string.Empty;
        }

        protected bool ValidateStoreFields()
        {
            return CurrentStore.Name != string.Empty &&
                   CurrentStore.Address.Street != string.Empty &&
                   CurrentStore.Address.City != string.Empty &&
                   CurrentStore.Address.Country != string.Empty &&
                   CurrentStore.Phone != string.Empty;
        }

        

        #endregion
    }
}
