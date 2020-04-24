
namespace Models
{
    public class Address
    {
        #region Private Fields
        private string _country;
        private string _city;
        private string _street;
        private double _latitude;
        private double _longitude;
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
        public double Latitude
        {
            get
            {
                return _latitude;
            }

            set
            {
                _latitude = value;
            }
        }
        public double Logitude
        {
            get
            {
                return _longitude;
            }

            set
            {
                _longitude = value;
            }
        }
        #endregion

        //Constructors



        //Methods



        //Overrides
    }
}
