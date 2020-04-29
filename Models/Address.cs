
namespace Models
{
    public class Address
    {
        #region Public Properties
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
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
