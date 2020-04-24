
namespace Models
{
    #region Enums
    public enum PrutitionalValue
    {
        Protein,
        Energy,
        Fat
    }
    #endregion

    public class Icecream
    {
        #region Private Fields
        private string _description;
        private string _pictureUrl;
        private PrutitionalValue _prutitionalValue;
        #endregion

        #region Public Properties
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
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
        public PrutitionalValue PrutitionalValue
        {
            get
            {
                return _prutitionalValue;
            }

            set
            {
                _prutitionalValue = value;
            }
        }
        #endregion

        //Constructors

        //Methods

        //Overrides
    }
}
