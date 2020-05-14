using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region Private Fields

        private List<HorizontalListStoreViewModel> _originalSource;
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
        public List<HorizontalListStoreViewModel> Items { get; set; } = new List<HorizontalListStoreViewModel>();

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
        public ICommand OnMouseDoubleClickCommand { get; set; }

        /// <summary>
        /// Fired when store selection changed
        /// </summary>
        public ICommand SelectedStoreChangedCommand { get; set; }

        #endregion

        #region Public Constructor

        public MainPageViewModel()
        {
            // Create commands
            LoadedCommand = new RelayCommand(() => Loaded());
            SelectedStoreChangedCommand = new RelayParameterizedCommand((parameter) => SelectedStoreChanged(parameter));
            OnMouseDoubleClickCommand = new RelayCommand(() => OnMouseDoubleClick());

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
            PopulateStores();
        }

        /// <summary>
        /// The logic for <see cref="SelectedStoreChangedCommand"/>
        /// </summary>
        /// <returns></returns>
        public void SelectedStoreChanged(object sender)
        {
            if (sender == null)
                return;

            if (!(sender is HorizontalListStoreViewModel))
                return;

            SelectedStore = sender as HorizontalListStoreViewModel;
        }

        /// <summary>
        /// The logic for <see cref="OnMouseDoubleClickCommand"/>
        /// </summary>
        /// <returns></returns>
        public void OnMouseDoubleClick()
        {
            MoveToStorePage();
        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public void MoveToStorePage()
        {
            IoC.Application.GoToPage(ApplicationPage.Store, SelectedStore);
        }

        #endregion

        #region Private Methods

        private void FilterItems()
        {
            var items = this._originalSource.Where(
                p => (string.IsNullOrEmpty(this.StoreName) || p.UpperHeader.ToLower().Contains(this.StoreName.ToLower()))
                     && (string.IsNullOrEmpty(this.City) || p.Description.Split(',')[1].ToLower().Contains(this.City.ToLower()))
                     && (string.IsNullOrEmpty(this.Country) || p.Description.Split(',')[2].ToLower().Contains(this.Country.ToLower()))).ToList();
            this.Items = items;
        }

        private void PopulateStores()
        {

            StoresList = new List<Store>()
            {
                new Store{
                    Name = "Main Page View Model 1",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop1.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 2",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop2.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 3",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop3.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 1",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop1.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 2",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop2.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 3",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop3.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page View Model 4",
                    Address = new Address
                    {
                        Street = "Street",
                        City = "City",
                        Country = "Country",
                    },

                    ImageUrl = @"/IceCreams;component/Images/shop4.png",
                    Phone = "Phone Number",
                    Icecreams = new List<Icecream>
                    {
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page View Model",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },
            };

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
