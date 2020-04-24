
namespace Models
{
    public struct Date
    {
        string Day;
        string Month;
        string Year;
    }

    public class Person
    {
        #region Private Fields

        #endregion

        #region Public Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date DateOfBirth { get; set; }
        #endregion

        //Constructors



        //Methods



        //Overrides
    }
}
