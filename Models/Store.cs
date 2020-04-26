using System.Collections.Generic;

namespace Models
{
    public class Store
    {
        #region Private Fields
        private Address _address;
        private string _pictureUrl;
        private string _phone;
        private List<Icecream> _icecreams;
        private Score _adminScore;
        private List<Score> _usersScores;
        #endregion

        #region Public Properties
        public Address Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }
        public string PictureUrl
        {
            get
            {
                return _pictureUrl;
            }

            set
            {
                _pictureUrl = value;
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
        public List<Icecream> Icecreams
        {
            get { return _icecreams; }
        }
        public Score AdminScore
        {
            get
            {
                return _adminScore;
            }

            set
            {
                _adminScore = value;
            }
        }
        public List<Score> UsersScores
        {
            get
            {
                return _usersScores;
            }
        }
        public string Name { get; set; }
        public int Stars { get; set; }
        #endregion

        //Constructors



        //Methods



        //Overrides
    }
}
