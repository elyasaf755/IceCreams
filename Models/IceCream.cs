
namespace Models
{
    #region Structs
    //TODO: Delete?
    public struct PrutitionalValue
    {
        public float Proteins; // חלבון 
        public float Calories; // קלוריות
        public float Fat; // שומן
    }
    #endregion

    public class Icecream
    {
        private static int _count;

        public readonly string IcecreamId;

        #region Public Properties

        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        #endregion

        #region Constructor

        public Icecream()
        {
            ++_count;
            IcecreamId = _count.ToString();
        }

        #endregion
    }
}
