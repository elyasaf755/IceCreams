using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        #region Private Fields

        private int _yearsRange = 120;
        private List<string> _months;
        private List<int> _years;

        #endregion

        #region Public Properties

        /// <summary>
        /// The user currently registering
        /// </summary>
        public User RegisteringUser { get; set; }

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The password of the user
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The range of the maximum days a month can have
        /// </summary>
        public List<int> Days { get => Enumerable.Range(1, 31).ToList(); }

        /// <summary>
        /// The range of the maximum months a year can have
        /// </summary>
        public List<string> Months { get => _months; }

        /// <summary>
        /// The years range a user can be born between
        /// </summary>
        public List<int> Years { get => _years; }

        #endregion

        #region Constructor

        public RegisterViewModel()
        {
            _years = Enumerable.Range(GetCurrentYear() - _yearsRange, _yearsRange + 1).ToList();
            _years.Reverse();

            _months = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
            _months.RemoveAll(x => string.IsNullOrEmpty(x));
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Gets the current year
        /// </summary>
        /// <returns></returns>
        private int GetCurrentYear()
        {
            //TODO: Get the actual year from the internet?
            return DateTime.Now.Year;
        }

        #endregion
    }
}