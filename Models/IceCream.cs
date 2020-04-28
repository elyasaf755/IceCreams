
namespace Models
{
    #region Structs
    public struct PrutitionalValue
    {
        public float Proteins; // חלבון 
        public float Calories; // קלוריות
        public float Fat; // שומן
    }
    #endregion

    public class Icecream
    {
        #region Public Properties

        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public PrutitionalValue PrutitionalValue { get; set; }

        #endregion

        //Constructors

        //Methods

        //Overrides
    }
}
