
namespace Models
{
    public class Address
    {
        #region Private Fields
        private string _country;
        private string _city;
        private string _street;
        #endregion

        #region Public Properties
        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }
        public string Street
        {
            get
            {
                return _street;
            }

            set
            {
                _street = value;
            }
        }
        #endregion

        //Constructors



        //Methods



        //Overrides
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Street, City, Country);
        }
    }
}
