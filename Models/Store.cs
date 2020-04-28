using System.Collections.Generic;

namespace Models
{
    public class Store
    {
        #region Public Properties

        public Address Address { get; set; }
        public string PictureUrl { get; set; }
        public string Phone { get; set; }
        public List<Icecream> Icecreams { get; set; }
        public Score AdminScore { get; set; }
        public List<Score> UsersScores { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }

        #endregion

        //Constructors



        //Methods



        //Overrides
    }
}
