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
        #region Public Properties
        /// <summary>
        /// List of all the stores
        /// </summary>
        public List<Store> StoresList { get; set; }

        /// <summary>
        /// Each item is a store
        /// </summary>
        public List<HorizontalListItemViewModel> Items { get; set; } = new List<HorizontalListItemViewModel>();

        /// <summary>
        /// The current selected store
        /// </summary>
        public HorizontalListItemViewModel SelectedStore { get; set; }

        /// <summary>
        /// The name of the store the user is looking for
        /// </summary>
        public string StoreName { get; set; }

        /// <summary>
        /// The country where the user is looking for stores in
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The city where the user is looking for stores in
        /// </summary>
        public string City { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Fired when the page is loaded
        /// </summary>
        public ICommand LoadedCommand { get; set; }

        /// <summary>
        /// Fired when store name is changed in the filters
        /// </summary>
        public ICommand StoreNameChangedCommand { get; set; }

        /// <summary>
        /// Fired when country name is changed in the filters
        /// </summary>
        public ICommand CountryChangedCommand { get; set; }

        /// <summary>
        /// Fired when city name is changed in the filters
        /// </summary>
        public ICommand CityChangedCommand { get; set; }

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
            LoadedCommand = new RelayCommand(async () => await Loaded());
            StoreNameChangedCommand = new RelayCommand(async () => await StoreNameChanged());
            CountryChangedCommand = new RelayCommand(async () => await CountryNameChanged());
            CityChangedCommand = new RelayCommand(async () => await CityNameChanged());
            SelectedStoreChangedCommand = new RelayParameterizedCommand(async (parameter) => await SelectedStoreChanged(parameter));
            OnMouseDoubleClickCommand = new RelayCommand(async () => await OnMouseDoubleClick());
        }

        #endregion


        #region Async Methods

        /// <summary>
        /// The logic for LoadedCommand
        /// </summary>
        /// <returns></returns>
        public async Task Loaded()
        {
            PopulateStores();

            await Task.Delay(1);
        }

        /// <summary>
        /// The logic for <see cref="StoreNameChangedCommand"/>
        /// </summary>
        /// <returns></returns>
        public async Task StoreNameChanged()
        {
            //Code here

            await Task.Delay(1);
        }

        /// <summary>
        /// The logic for <see cref="CountryChangedCommand"/>
        /// </summary>
        /// <returns></returns>
        public async Task CountryNameChanged()
        {
            //Code here

            await Task.Delay(1);
        }

        /// <summary>
        /// The logic for <see cref="CityChangedCommand"/>
        /// </summary>
        /// <returns></returns>
        public async Task CityNameChanged()
        {
            //Code here

            await Task.Delay(1);
        }

        /// <summary>
        /// The logic for <see cref="SelectedStoreChangedCommand"/>
        /// </summary>
        /// <returns></returns>
        public async Task SelectedStoreChanged(object sender)
        {
            if (sender == null)
                return;

            if (!(sender is HorizontalListItemViewModel))
                return;

            SelectedStore = sender as HorizontalListItemViewModel;

            await Task.Delay(1);
        }

        /// <summary>
        /// The logic for <see cref="OnMouseDoubleClickCommand"/>
        /// </summary>
        /// <returns></returns>
        public async Task OnMouseDoubleClick()
        {
            await MoveToStorePage();
        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task MoveToStorePage()
        {
            //TODO: code here
            throw new NotImplementedException();
            await Task.Delay(1);
        }

        #endregion

        //TODO: DELETE BEFORE DEPLOY
        #region DELETE BEFORE DEPLOY

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
                this.Items.Add(new HorizontalListItemViewModel()
                {
                    UpperHeader = store.Name,
                    ImageUrl = store.ImageUrl,
                    Description = store.Address.ToString(),
                    LowerHeader = store.Phone
                });
            }
        }

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
