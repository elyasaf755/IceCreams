using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class MainPageDesignModel : MainPageViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MainPageDesignModel Instance => new MainPageDesignModel();

        #endregion

        public MainPageDesignModel()
        {
            PopulateStores();
        }

        private void PopulateStores()
        {

            StoresList = new List<Store>()
            {
                new Store{
                    Name = "Main Page Design Model 1",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 2",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 3",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 4",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 1",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 2",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 3",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 4",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 1",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 2",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 3",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 4",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 1",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 2",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 3",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Main Page Design Model 4",
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
                            Name = "Main Page Design Model 1",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 2",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 3",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Main Page Design Model 4",
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
                    LowerHeader = store.Phone
                });
            }
        }
    }
}
