using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public static class DataSource
    {
        public static List<Store> StoresList { get; set; }

        static DataSource()
        {
            StoresList = new List<Store>()
            {
                new Store{
                    Name = "Data Source 1",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 2",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 3",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 1",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 2",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 3",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },

                new Store{
                    Name = "Data Source 4",
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
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 1",
                            Price = "10",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item2.jpg",
                            Description = "Item 2",
                            Price = "20",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item3.jpg",
                            Description = "Item 3",
                            Price = "30",
                        },
                        new Icecream
                        {
                            Name = "Data Source",
                            ImageUrl = @"/IceCreams;component/Images/Items/icecream_item1.jpg",
                            Description = "Item 4",
                            Price = "40",
                        },
                    },
                },
            };
        }
    }
}
