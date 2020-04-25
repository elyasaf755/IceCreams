using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

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

        #region Commands

        /// <summary>
        /// The command to change the page to the register date page
        /// </summary>
        public ICommand MoveToRegisterDatePageCommand { get; set; }

        /// <summary>
        /// The command to change the page to the register password page
        /// </summary>
        public ICommand MoveToRegisterPasswordPageCommand { get; set; }

        #endregion

        #region Constructor

        public RegisterViewModel()
        {
            _years = Enumerable.Range(GetCurrentYear() - _yearsRange, _yearsRange + 1).ToList();
            _years.Reverse();

            _months = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
            _months.RemoveAll(x => string.IsNullOrEmpty(x));

            MoveToRegisterDatePageCommand = new RelayCommand(async () => await MoveToRegisterDatePage());
            MoveToRegisterPasswordPageCommand = new RelayCommand(async () => await MoveToRegisterPasswordPage());
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

        /// <summary>
        /// Takes the user to the register date page
        /// </summary>
        /// <returns></returns>
        public async Task MoveToRegisterDatePage()
        {
            // TODO: Complete this function's logic

            // Go to register date page
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.RegisterDate;

            await Task.Delay(1);
        }

        /// <summary>
        /// Takes the user to the register password page
        /// </summary>
        /// <returns></returns>
        public async Task MoveToRegisterPasswordPage()
        {
            // TODO: Complete this function's logic

            // Go to register date page
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.RegisterPassword;

            await Task.Delay(1);
        }
    }
}