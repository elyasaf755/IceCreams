using System.Collections.Generic;

namespace Models
{
    public class Store
    {
        private static int _count = 0;

        #region Public Fields

        public readonly string StoreId;

        #endregion

        #region Public Properties

        public Address Address { get; set; } = new Address();
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public List<Icecream> Icecreams { get; set; } = new List<Icecream>();
        public string Name { get; set; }

        #endregion

        public Store()
        {
            ++_count;
            StoreId = _count.ToString();
        }
    }
}
