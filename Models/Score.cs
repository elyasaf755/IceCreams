using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Models
{
    public class Score
    {
        #region Private Fields
        private User _user;
        private int _grade;
        private ResourceManager _stringManager = new ResourceManager("en-US", Assembly.GetExecutingAssembly());
        #endregion

        #region Public Properties
        public User User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }
        public int Grade
        {
            get
            {
                return _grade;
            }

            set
            {
                if (value <= 5 && value >= 1)
                {
                    _grade = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        "Grade",
                        _stringManager.GetString(
                            "Grade must have values as follow: 0 <= Grade <= 5",
                            CultureInfo.CurrentUICulture)
                        );
                }
            }
        }
        #endregion

        //Constructors



        //Methods



        //Overrides
    }
}
